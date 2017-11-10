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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 57);
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbPower);
            this.panel1.Controls.Add(this.txtBearing);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtElevation);
            this.panel1.Location = new System.Drawing.Point(5, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 95);
            this.panel1.TabIndex = 25;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOk.Location = new System.Drawing.Point(0, 172);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(178, 44);
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
            this.btnCancel.Location = new System.Drawing.Point(0, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdvancedCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 247);
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
    }
}