using Ss13Telescience.CoordinatesHistory;
using Ss13Telescience.TrajectoryCalculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ss13Telescience {
    public partial class Telescience : Form {

        CoordinateHistory History;
        TrajectoryCalculator trajcalc;
        private int uses = 0;
        private String tmpTxtText = "0";

        InstructionsPanel instructions = new InstructionsPanel();

        public Telescience() {
            InitializeComponent();

            // Add paste events to the coordinates inputs
            txtInPadLocX.Paste += pastePadLoc;
            txtInPadLocY.Paste += pastePadLoc;
            txtInCalLocX.Paste += pasteCalLoc;
            txtInCalLocY.Paste += pasteCalLoc;
            txtInDstX.Paste += pasteDstLoc;
            txtInDstY.Paste += pasteDstLoc;

            setCalibrateButtonText();

            // Sets the window position from last saved:
            int posX = Properties.Settings.Default.formPosX;
            int posY = Properties.Settings.Default.formPosY;
            if(posX >= 0 && posY >= 0) {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point( posX, posY );
            }
        }

        private void Telescience2_Load(object sender, EventArgs e) {
            // Initialize stuff
            this.History = new CoordinateHistory( this.GetCalculator );
            this.trajcalc = TrajectoryCalculator.createCalculator( 0, 0, 0, 0, 0, 0, 0, TrajectoryCalculator.CalculationOptionsList[Properties.Settings.Default.selectedServer].CalcType );

            // Topmost window setting
            chkOnTop.Checked = Properties.Settings.Default.checkOnTop;
            this.TopMost = chkOnTop.Checked;
        }


        #region Button behaviour

        // Paste values to the coordinates input using the paste "<" button.

        private void pasteToXYPad_Click(object sender, EventArgs e) {
            if(Clipboard.ContainsText()) {
                pasteToXY( txtInPadLocX, txtInPadLocY, Clipboard.GetText() );
            }
        }
        private void pasteToXYCal_Click(object sender, EventArgs e) {
            if(Clipboard.ContainsText()) {
                pasteToXY( txtInCalLocX, txtInCalLocY, Clipboard.GetText() );
            }
        }
        private void pasteToXYDst_Click(object sender, EventArgs e) {
            if(Clipboard.ContainsText()) {
                pasteToXY( txtInDstX, txtInDstY, Clipboard.GetText() );
            }
        }


        /// <summary>
        /// Read calibration settings inputs, loads them into a new Trajectory Calculator and calculates the new offsets.
        /// </summary>
        private void btnCalibrate_Click(object sender, EventArgs e) {
            // Reads data from the inputs
            int padX = Util.readInt( txtInPadLocX );
            int padY = Util.readInt( txtInPadLocY );
            int calX = Util.readInt( txtInCalLocX );
            int calY = Util.readInt( txtInCalLocY );

            // Reads bearing, elevation and power settings
            float calBearing = Properties.Settings.Default.selectedBearing;
            float calElevation = Properties.Settings.Default.selectedElevation;
            int calPower = Properties.Settings.Default.selectedPower;

            // Calculates the offsets based on the data
            trajcalc = TrajectoryCalculator.createCalculator( padX, padY, calX, calY, calPower, calBearing, calElevation, TrajectoryCalculator.CalculationOptionsList[Properties.Settings.Default.selectedServer].CalcType );
            trajcalc.calcOffsets();

            // Shows the result to the user
            lblCalBe.Text = trajcalc.bearingOffset.ToString();
            lblCalPow.Text = trajcalc.powerOffset.ToString();
            setStatus( "Calibrated" );

            // Enables the compute box, initially disabled due the lack of a valid TrajectoryCalculator object.
            grpCompute.Enabled = true;

            uses = 0;
            lblUses.Text = uses.ToString();

        }

        /// <summary>
        /// Calculates the bearing, elevation and power using the TrajectoryCalculator object that was created at the calibration process.
        /// </summary>
        private void btnCalculate_Click(object sender, EventArgs e) {

            // Read target coordinates from text inputs.
            int xTarget = Util.readInt( txtInDstX );
            int yTarget = Util.readInt( txtInDstY );

            if(trajcalc != null) { // If its null it means the calibration button wasn't used or something bad happened.
                if(trajcalc.calcAll( xTarget, yTarget )) {
                    // If the calculation went ok, show the results to the user.
                    btnCpyBearing.Text = Math.Round( trajcalc.resBearing, 2 ).ToString();
                    btnCpyElevation.Text = Math.Round( trajcalc.resElevation, 1 ).ToString();
                    btnCpyPower.Text = trajcalc.resPower.ToString();
                    setStatus( "Calculation done! Results ready" );

                    History.CalculationPerormed( xTarget, yTarget, trajcalc.resBearing, trajcalc.resElevation, trajcalc.resPower );
                } else {
                    // If the calculation went wrong, show the error to the user.
                    btnCpyBearing.Text = btnCpyElevation.Text = btnCpyPower.Text = "-";
                    setStatus( trajcalc.status );
                }
            } else {
                setStatus( "Error: Needs calibration" );
            }
        }

        /// <summary>
        /// Copy the button text to the clipboard to direct use into the game telepad console.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCpyToCliboard_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            System.Windows.Forms.Clipboard.SetText( btn.Text );
            setStatus( "Value " + btn.Text + " copied to clipboard" );
        }

        /// <summary>
        /// Manually adds to the "Uses" counter. It allows to manually keep track of the number of teleportations.
        /// </summary>
        private void btnUsesAdd_Click(object sender, EventArgs e) {
            uses++;
            lblUses.Text = uses.ToString();
        }


        /// <summary>
        /// Shows a new dialog to set the bearing, elevation and power that will be used to send the gps probe.
        /// </summary>
        private void btnAdvancedOptions_Click(object sender, EventArgs e) {
            // Creates the dialog and reads the result
            var newDialog = new AdvancedCalibration( trajcalc.bearingOffset, trajcalc.powerOffset );
            newDialog.TopMost = this.TopMost; // Avoid the new dialog to stay behind the main form.
            DialogResult result = newDialog.ShowDialog();

            if(result == DialogResult.Cancel) setStatus( "Calibration settings not modified" );
            else if(result == DialogResult.OK) {
                grpCompute.Enabled = grpCompute.Enabled || trajcalc.bearingOffset != newDialog.currentBearingOffset || trajcalc.powerOffset != newDialog.currentPowerOffset;
                this.trajcalc.setOffsets( newDialog.currentBearingOffset, newDialog.currentPowerOffset );

                // Shows the result to the user
                setCalibrateButtonText();
                lblCalBe.Text = trajcalc.bearingOffset.ToString();
                lblCalPow.Text = trajcalc.powerOffset.ToString();


                setStatus( "New calibration settings saved!" );
            }
        }

        /// <summary>
        /// Shows the About window
        /// </summary>
        private void btnAbout_Click(object sender, EventArgs e) {
            if(instructions.Visible) instructions.Hide();
            instructions.documentType = InstructionsPanel.documentTypes.About;
            instructions.Show();
        }

        /// <summary>
        /// Shows the Instructions window
        /// </summary>
        private void btnInstructions_Click(object sender, EventArgs e) {
            if(instructions.Visible) instructions.Hide();
            instructions.documentType = InstructionsPanel.documentTypes.Instructions;
            instructions.Show();
        }

        #endregion



        #region Key events

        /// <summary>
        /// Filters keys to only allow numbers in the textboxes.
        /// </summary>
        private void txtFilterDigits_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar );
        }

        /// <summary>
        /// Stores the textbox value in tmpTxtText variable and empties it, for usability.
        /// The focus leave event make sure it doesn't stay empty.
        /// </summary>
        private void txtFocus_Enter(object sender, EventArgs e) {
            tmpTxtText = ( (TextBox)sender ).Text;
            ( (TextBox)sender ).Text = "";
        }

        /// <summary>
        /// Makes sure the textboxes are not left empty or with non-numeric text.
        /// If its empty or the text is wrong, it uses the last known value.
        /// If that was empty, it writes a 0.
        /// </summary>
        private void txtNonEmpty_Leave(object sender, EventArgs e) {
            TextBox txt = (TextBox)sender;

            if(txt.Text.Length == 0) {
                if(tmpTxtText.Length == 0) txt.Text = "0";
                else txt.Text = tmpTxtText;
            } else {
                int parsed; // Only used to check if the value is an integer.
                if(!int.TryParse( txt.Text, out parsed )) {
                    if(tmpTxtText.Length == 0) txt.Text = "0";
                    else txt.Text = tmpTxtText;
                }
            }

        }

        /// <summary>
        /// Checks if the textbox value is an integer.
        /// </summary>
        /// <returns>Returns true if is an integer, false otherwise.</returns>
        bool pasteTxtCheckForInt(TextBoxPaste txt) {
            int readed;
            if(int.TryParse( txt.GetPastedText(), out readed )) {
                txt.Text = readed.ToString();
                return true;
            }
            return false;
        }

        //
        // Handle the paste event from the coordinates inputs.
        //
        private void pastePadLoc(object sender, EventArgs e) {
            TextBoxPaste txt = (TextBoxPaste)sender;
            if(pasteTxtCheckForInt( txt )) return;
            if(pasteToXY( txtInPadLocX, txtInPadLocY, txt.GetPastedText() )) txtInCalLocX.Focus();
        }
        private void pasteCalLoc(object sender, EventArgs e) {
            TextBoxPaste txt = (TextBoxPaste)sender;
            if(pasteTxtCheckForInt( txt )) return;
            if(pasteToXY( txtInCalLocX, txtInCalLocY, txt.GetPastedText() )) btnCalibrate.Focus();
        }
        private void pasteDstLoc(object sender, EventArgs e) {
            TextBoxPaste txt = (TextBoxPaste)sender;
            if(pasteTxtCheckForInt( txt )) return;
            if(pasteToXY( txtInDstX, txtInDstY, txt.GetPastedText() )) {
                // If the paste was successful, perform the calculation.
                btnCalculate.Focus();
                btnCalculate.PerformClick();
            }

        }


        /// <summary>
        /// Checks for enter key and clicks the calibrate button.
        /// </summary>
        private void txtCalibrate_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                btnCalibrate.Focus();
                btnCalibrate.PerformClick();
            }
        }
        /// <summary>
        /// Checks for enter key and clicks the calculate button.
        /// </summary>
        private void txtCalculate_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                btnCalculate.Focus();
                btnCalculate.PerformClick();
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e) {
            // Opens the directory window.
            this.History.Show();
        }

        public TrajectoryCalculator GetCalculator() {
            return this.trajcalc;
        }


        #endregion



        #region Misc methods

        /// <summary>
        /// Attempts to get the X and Y coordinates from the received string using a regular expression.
        /// If successful, adds the coordinates to the received textboxes.
        /// </summary>
        private bool pasteToXY(TextBox txtX, TextBox txtY, String text) {

            text = text.Trim();
            var groups = Regex.Match( text, @"\(? *(?<n1>\d+)[\, ]*(?<n2>\d+) *\)?" ).Groups;

            int n1;
            int n2;
            if(int.TryParse( groups["n1"].ToString(), out n1 ) && int.TryParse( groups["n2"].ToString(), out n2 )) {
                txtX.Text = n1.ToString();
                txtY.Text = n2.ToString();

                setStatus( "Coordinates successfully parsed!" );
                return true;
            }
            setStatus( "Unable to parse the coordinates..." );
            return false;
        }

        /// <summary>
        /// Sets the status text (the label at the bottom-left corner).
        /// </summary>
        private void setStatus(String text) {
            lblStatus.Text = text;
        }

        /// <summary>
        /// TopMost checkbox event. Saves the last status.
        /// </summary>
        private void chkOnTop_CheckedChanged(object sender, EventArgs e) {
            CheckBox chk = (CheckBox)sender;
            this.TopMost = chk.Checked;
            Properties.Settings.Default.checkOnTop = chk.Checked;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// Saves the window location, so it will be in the same place when opened again.
        /// </summary>
        private void Telescience_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.formPosX = this.Location.X;
            Properties.Settings.Default.formPosY = this.Location.Y;
            Properties.Settings.Default.Save();

            this.History.Hide();
            this.History.Close();
        }

        /// <summary>
        /// Updates the text from the "Calibrate" button, adding the bearing, elevation and power that are used to send the gps probe.
        /// </summary>
        private void setCalibrateButtonText() {
            string calData = @"" +
                Properties.Settings.Default.selectedBearing + ", " +
                Properties.Settings.Default.selectedElevation + ", " +
                Properties.Settings.Default.selectedPower;
            btnCalibrate.Text = "Calibrate (" + calData + ")";

            toolTip1.SetToolTip( btnCalibrate, @"Calculates the offsets using the provided coordinates." + Environment.NewLine +
                "Assumes the probe was sent with:\n" +
                " Bearing: " + Properties.Settings.Default.selectedBearing + "\n" +
                " Elevation: " + Properties.Settings.Default.selectedElevation + "\n" +
                " Power: " + Properties.Settings.Default.selectedPower );
        }














        /// <summary>
        /// Test a trajectory (not tested).
        /// </summary>
        /*void testTrajectory(int src_x, int src_y, float rotation, float angle, int power) {

            double power_x = power * Math.Cos( angle );
            double power_y = power * Math.Sin( angle );
            double time = 2 * power_y / 10d;

            double distance = time * power_x;

            double dest_x = Math.Round( src_x + distance * Math.Sin( rotation ) );
            double dest_y = Math.Round( src_y + distance * Math.Cos( rotation ) );

            MessageBox.Show( "Destination: X: " + dest_x + " Y: " + dest_y );
        }*/

        #endregion

        private void btnCalculate_KeyUp(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.B) {
                btnCpyBearing.PerformClick();
            } else if(e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.E) {
                btnCpyElevation.PerformClick();
            } else if(e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.P) {
                btnCpyPower.PerformClick();
            }
        }
    }
}
