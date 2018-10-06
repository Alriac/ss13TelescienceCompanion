namespace Ss13Telescience {
    partial class AdvancedCalibration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && ( components != null )) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBearing = new System.Windows.Forms.TextBox();
            this.txtElevation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPower = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBearingOffset = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPowerOffset = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbServerSelection = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input here the values you are going to use to send the gps probe.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bearing:";
            // 
            // txtBearing
            // 
            this.txtBearing.Location = new System.Drawing.Point(108, 4);
            this.txtBearing.Name = "txtBearing";
            this.txtBearing.Size = new System.Drawing.Size(46, 23);
            this.txtBearing.TabIndex = 0;
            this.txtBearing.Click += new System.EventHandler(this.txtFocus_Enter);
            this.txtBearing.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtBearing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtBearing.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            // 
            // txtElevation
            // 
            this.txtElevation.Location = new System.Drawing.Point(108, 33);
            this.txtElevation.Name = "txtElevation";
            this.txtElevation.Size = new System.Drawing.Size(46, 23);
            this.txtElevation.TabIndex = 1;
            this.txtElevation.Click += new System.EventHandler(this.txtFocus_Enter);
            this.txtElevation.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtElevation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtElevation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Elevation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Power:";
            // 
            // cmbPower
            // 
            this.cmbPower.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "25",
            "30",
            "40",
            "50",
            "80"});
            this.cmbPower.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPower.ItemHeight = 16;
            this.cmbPower.Items.AddRange(new object[] {
            "20",
            "25",
            "30",
            "40",
            "50",
            "80"});
            this.cmbPower.Location = new System.Drawing.Point(108, 62);
            this.cmbPower.MaxLength = 2;
            this.cmbPower.Name = "cmbPower";
            this.cmbPower.Size = new System.Drawing.Size(46, 24);
            this.cmbPower.TabIndex = 2;
            this.cmbPower.TabStop = false;
            this.cmbPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.cmbPower.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            this.cmbPower.Leave += new System.EventHandler(this.cmbPower_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbPower);
            this.panel1.Controls.Add(this.txtBearing);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtElevation);
            this.panel1.Location = new System.Drawing.Point(5, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 95);
            this.panel1.TabIndex = 25;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOk.Location = new System.Drawing.Point(0, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(375, 44);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Save Values";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(0, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(375, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(184, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 90);
            this.label5.TabIndex = 26;
            this.label5.Text = "Here you can manually set some calculated offsets without calibrating.\r\nUseful wh" +
    "en another player shares them to you.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBearingOffset);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPowerOffset);
            this.panel2.Location = new System.Drawing.Point(181, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 61);
            this.panel2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Bearing Offset:";
            // 
            // txtBearingOffset
            // 
            this.txtBearingOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBearingOffset.Location = new System.Drawing.Point(129, 4);
            this.txtBearingOffset.Name = "txtBearingOffset";
            this.txtBearingOffset.Size = new System.Drawing.Size(46, 23);
            this.txtBearingOffset.TabIndex = 0;
            this.txtBearingOffset.Click += new System.EventHandler(this.txtFocus_Enter);
            this.txtBearingOffset.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtBearingOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtBearingOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Power Offset:";
            // 
            // txtPowerOffset
            // 
            this.txtPowerOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPowerOffset.Location = new System.Drawing.Point(129, 33);
            this.txtPowerOffset.Name = "txtPowerOffset";
            this.txtPowerOffset.Size = new System.Drawing.Size(46, 23);
            this.txtPowerOffset.TabIndex = 1;
            this.txtPowerOffset.Click += new System.EventHandler(this.txtFocus_Enter);
            this.txtPowerOffset.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtPowerOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtPowerOffset.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(176, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 160);
            this.label7.TabIndex = 27;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbServerSelection);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 57);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server selection";
            // 
            // cmbServerSelection
            // 
            this.cmbServerSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerSelection.FormattingEnabled = true;
            this.cmbServerSelection.Location = new System.Drawing.Point(14, 23);
            this.cmbServerSelection.Name = "cmbServerSelection";
            this.cmbServerSelection.Size = new System.Drawing.Size(345, 24);
            this.cmbServerSelection.TabIndex = 0;
            // 
            // AdvancedCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdvancedCalibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Calibration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBearing;
        private System.Windows.Forms.TextBox txtElevation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPower;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBearingOffset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPowerOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbServerSelection;
    }
}