namespace Ss13Telescience.CoordinatesHistory {
    partial class CoordinateHistory {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinateHistory));
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.coordinatesItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRecalculate = new System.Windows.Forms.Button();
            this.chkAutoAdd = new System.Windows.Forms.CheckBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bearingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elevationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.bearingDataGridViewTextBoxColumn,
            this.elevationDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.Delete});
            this.dgvHistory.DataSource = this.coordinatesItemBindingSource;
            this.dgvHistory.Location = new System.Drawing.Point(10, 113);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHistory.Size = new System.Drawing.Size(511, 564);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistory_CellContentClick);
            // 
            // coordinatesItemBindingSource
            // 
            this.coordinatesItemBindingSource.DataSource = typeof(Ss13Telescience.CoordinatesHistory.CoordinatesItem);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Every calculation will be added to this list if the checkbox is enabled.\r\nThis pr" +
    "ovides fast access to the targets that you already calculated.";
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.BackColor = System.Drawing.Color.Sienna;
            this.btnRecalculate.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnRecalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRecalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecalculate.Location = new System.Drawing.Point(12, 69);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(175, 33);
            this.btnRecalculate.TabIndex = 23;
            this.btnRecalculate.TabStop = false;
            this.btnRecalculate.Text = "Recalculate all targets";
            this.toolTip1.SetToolTip(this.btnRecalculate, "Pressing this button will recalculate\r\nall the coordinates on the list with the\r\n" +
        "current offsets.");
            this.btnRecalculate.UseVisualStyleBackColor = false;
            this.btnRecalculate.Click += new System.EventHandler(this.btnRecalculate_Click);
            // 
            // chkAutoAdd
            // 
            this.chkAutoAdd.AutoSize = true;
            this.chkAutoAdd.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoAdd.Checked = true;
            this.chkAutoAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkAutoAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.chkAutoAdd.Location = new System.Drawing.Point(193, 74);
            this.chkAutoAdd.Name = "chkAutoAdd";
            this.chkAutoAdd.Size = new System.Drawing.Size(240, 24);
            this.chkAutoAdd.TabIndex = 24;
            this.chkAutoAdd.TabStop = false;
            this.chkAutoAdd.Text = "Automatically add calculations";
            this.toolTip1.SetToolTip(this.chkAutoAdd, "Check if you want new calculations \r\nto be autimatically added");
            this.chkAutoAdd.UseVisualStyleBackColor = false;
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.BackColor = System.Drawing.Color.Transparent;
            this.chkOnTop.Checked = true;
            this.chkOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnTop.ForeColor = System.Drawing.SystemColors.Control;
            this.chkOnTop.Location = new System.Drawing.Point(439, 77);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(70, 21);
            this.chkOnTop.TabIndex = 25;
            this.chkOnTop.TabStop = false;
            this.chkOnTop.Text = "On top";
            this.toolTip1.SetToolTip(this.chkOnTop, "Keep this window always on top");
            this.chkOnTop.UseVisualStyleBackColor = false;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 180;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.xDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            this.xDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.xDataGridViewTextBoxColumn.Width = 40;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.yDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.ReadOnly = true;
            this.yDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.yDataGridViewTextBoxColumn.Width = 40;
            // 
            // bearingDataGridViewTextBoxColumn
            // 
            this.bearingDataGridViewTextBoxColumn.DataPropertyName = "Bearing";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "-";
            this.bearingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.bearingDataGridViewTextBoxColumn.HeaderText = "Bearing";
            this.bearingDataGridViewTextBoxColumn.Name = "bearingDataGridViewTextBoxColumn";
            this.bearingDataGridViewTextBoxColumn.ReadOnly = true;
            this.bearingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bearingDataGridViewTextBoxColumn.Width = 65;
            // 
            // elevationDataGridViewTextBoxColumn
            // 
            this.elevationDataGridViewTextBoxColumn.DataPropertyName = "Elevation";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N1";
            dataGridViewCellStyle4.NullValue = "-";
            this.elevationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.elevationDataGridViewTextBoxColumn.HeaderText = "Elevation";
            this.elevationDataGridViewTextBoxColumn.Name = "elevationDataGridViewTextBoxColumn";
            this.elevationDataGridViewTextBoxColumn.ReadOnly = true;
            this.elevationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.elevationDataGridViewTextBoxColumn.Width = 70;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.powerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.powerDataGridViewTextBoxColumn.Width = 55;
            // 
            // Delete
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.NullValue = "X";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle6;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "X";
            this.Delete.Width = 60;
            // 
            // CoordinateHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(531, 687);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.chkAutoAdd);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 1500);
            this.MinimumSize = new System.Drawing.Size(547, 500);
            this.Name = "CoordinateHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coordinate History List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoordinateHistory_FormClosing);
            this.Load += new System.EventHandler(this.CoordinateHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coordinatesItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.BindingSource coordinatesItemBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRecalculate;
        private System.Windows.Forms.CheckBox chkAutoAdd;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bearingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elevationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}