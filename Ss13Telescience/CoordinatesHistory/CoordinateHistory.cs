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

namespace Ss13Telescience.CoordinatesHistory {
    public partial class CoordinateHistory : Form {

        Func<TrajectoryCalculator> GetCalculator;
        List<CoordinatesItem> CoordinatesList { get; set; }

        public CoordinateHistory(Func<TrajectoryCalculator> GetCalculator) {
            InitializeComponent();

            // Sets the window position from last saved:
            int posX = Properties.Settings.Default.historyPosX;
            int posY = Properties.Settings.Default.historyPosY;
            if(posX >= 0 && posY >= 0) {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point( posX, posY );
            }

            coordinatesItemBindingSource.DataSource = new BindingList<CoordinatesItem>();

            this.GetCalculator = GetCalculator;

        }


        private void CoordinateHistory_Load(object sender, EventArgs e) {
            // Topmost window setting
            chkOnTop.Checked = Properties.Settings.Default.historyCheckOnTop;
            this.TopMost = chkOnTop.Checked;
        }

        /// <summary>
        /// Adds a new calculation to the history if the option is enabled and is not already in the list.
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Bearing"></param>
        /// <param name="Elevation"></param>
        /// <param name="Power"></param>
        public void CalculationPerormed(int X, int Y, double Bearing, double Elevation, int Power, string Name = null) {
            if(this.chkAutoAdd.Checked) {
                CoordinatesItem NewItem = new CoordinatesItem() {
                    X = X,
                    Y = Y,
                    Bearing = Bearing,
                    Elevation = Elevation,
                    Power = Power,
                    Name = string.IsNullOrWhiteSpace( Name ) ? $"({X}, {Y})" : Name
                };

                if(!coordinatesItemBindingSource.Contains( NewItem )) {
                    coordinatesItemBindingSource.Add( NewItem );
                }
            }
        }

        private void btnRecalculate_Click(object sender, EventArgs e) {
            if(MessageBox.Show( "Recalculate all coordinates in\nthe list with the current offsets?", "Recalculate", MessageBoxButtons.OKCancel, MessageBoxIcon.Question ) == DialogResult.OK) {

                TrajectoryCalculator trajcalc = GetCalculator();
                foreach(var Coordinates in coordinatesItemBindingSource.Cast<CoordinatesItem>()) {
                    trajcalc.calcAll( Coordinates.X, Coordinates.Y );
                    Coordinates.Bearing = trajcalc.resBearing;
                    Coordinates.Elevation = trajcalc.resElevation;
                    Coordinates.Power = trajcalc.resPower;
                }

                dgvHistory.DataSource = null;
                dgvHistory.DataSource = coordinatesItemBindingSource;
            }
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e) {
            CheckBox chk = (CheckBox)sender;
            this.TopMost = chk.Checked;
            Properties.Settings.Default.historyCheckOnTop = chk.Checked;
            Properties.Settings.Default.Save();
        }

        private void CoordinateHistory_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.historyPosX = this.Location.X;
            Properties.Settings.Default.historyPosY = this.Location.Y;
            Properties.Settings.Default.Save();

            if(this.Visible)
                e.Cancel = true;

            this.Hide();
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            DataGridView dg = sender as DataGridView;

            if(dg.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                coordinatesItemBindingSource.Remove( dg.Rows[e.RowIndex].DataBoundItem );
            }
        }
    }
}
