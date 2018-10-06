using Ss13Telescience.TrajectoryCalculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ss13Telescience {
    public partial class AdvancedCalibration : Form {


        public int currentBearingOffset { get; set; }
        public int currentPowerOffset { get; set; }

        public AdvancedCalibration(int currentBearingOffset, int currentPowerOffset) {
            InitializeComponent();

            txtBearing.Text = Properties.Settings.Default.selectedBearing.ToString( "F0" );
            txtElevation.Text = Properties.Settings.Default.selectedElevation.ToString( "F0" );
            cmbPower.Text = Properties.Settings.Default.selectedPower.ToString();

            this.txtBearingOffset.Text = ( this.currentBearingOffset = currentBearingOffset ).ToString( "F0" );
            this.txtPowerOffset.Text = ( this.currentPowerOffset = currentPowerOffset ).ToString( "F0" );


            cmbServerSelection.Items.AddRange( TrajectoryCalculator.CalculationOptionsList );
            cmbServerSelection.SelectedIndex = Properties.Settings.Default.selectedServer;

            txtBearing.Focus();
        }

        private void cmbPower_Leave(object sender, EventArgs e) {

        }

        /// <summary>
        /// Read and save the new values. Show error message if they are wrong.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e) {

            // Read and validate all 3 inputs from calibration settings

            int bearing = Util.readInt( txtBearing, -1 );
            if ( bearing < 0 || bearing > 359 ) {
                MessageBox.Show( "The bearing must be a number from 0 to 359" );
                return;
            }
            int elevation = Util.readInt( txtElevation );
            if ( elevation < 5 || elevation > 89 ) {
                MessageBox.Show( "The elevation must be a number from 5 to 89" );
                return;
            }
            int power = Util.readInt( cmbPower );
            if ( power < 5 || power > 80 ) {
                MessageBox.Show( "The power must be a number from 5 to 80" );
                return;
            }

            // Read and validate all 2 inputs from manual calibration
            int bearingOffset = Util.readInt( txtBearingOffset, -1000 );
            if ( bearingOffset < -359 || bearingOffset > 359 ) {
                MessageBox.Show( "The manual bearing offset must be a number from -359 to 359" );
                return;
            }
            int powerOffset = Util.readInt( txtPowerOffset, -1000 );
            if ( powerOffset < -44 || powerOffset > 44 ) {
                MessageBox.Show( "The manual power offset must be a number from -44 to 44" );
                return;
            }

            int SelectedOption = cmbServerSelection.SelectedIndex;
            if ( SelectedOption < 0 ) {
                MessageBox.Show( "Invalid server selected" );
                return;
            }

            // Save the new values
            Properties.Settings.Default.selectedBearing = bearing;
            Properties.Settings.Default.selectedElevation = elevation;
            Properties.Settings.Default.selectedPower = power;
            Properties.Settings.Default.selectedServer = SelectedOption;

            currentBearingOffset = bearingOffset;
            currentPowerOffset = powerOffset;

            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Cancels the dialog, do not save the values.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtCalibrate_KeyUp(object sender, KeyEventArgs e) {
            if ( e.KeyCode == Keys.Enter ) {
                //btnOk.Focus();
                btnOk.PerformClick();
            } else if ( e.KeyCode == Keys.Escape ) {
                btnCancel.PerformClick();
            }
        }
        private void txtFocus_Enter(object sender, EventArgs e) {
            ( (TextBox)sender ).SelectAll();
        }
        private void txtFilterDigits_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit( e.KeyChar ) && !char.IsControl( e.KeyChar ) && !( e.KeyChar == '-' && !( sender as TextBoxBase ).Text.Contains( "-" ) );
        }

    }
}
