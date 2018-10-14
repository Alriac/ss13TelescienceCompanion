namespace Ss13Telescience {
    partial class Telescience {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telescience));
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.btnAdvancedOptions = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblCalPow = new System.Windows.Forms.Label();
            this.lblCalBe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsesAdd = new System.Windows.Forms.Button();
            this.lblUses = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCompute = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.btnCpyPower = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCpyElevation = new System.Windows.Forms.Button();
            this.btnCpyBearing = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtInDstY = new Ss13Telescience.TextBoxPaste();
            this.txtInDstX = new Ss13Telescience.TextBoxPaste();
            this.txtInCalLocY = new Ss13Telescience.TextBoxPaste();
            this.txtInCalLocX = new Ss13Telescience.TextBoxPaste();
            this.txtInPadLocY = new Ss13Telescience.TextBoxPaste();
            this.txtInPadLocX = new Ss13Telescience.TextBoxPaste();
            this.grpSetup.SuspendLayout();
            this.grpCompute.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSetup
            // 
            this.grpSetup.BackColor = System.Drawing.Color.Transparent;
            this.grpSetup.Controls.Add(this.btnAdvancedOptions);
            this.grpSetup.Controls.Add(this.button5);
            this.grpSetup.Controls.Add(this.button4);
            this.grpSetup.Controls.Add(this.txtInCalLocY);
            this.grpSetup.Controls.Add(this.txtInCalLocX);
            this.grpSetup.Controls.Add(this.txtInPadLocY);
            this.grpSetup.Controls.Add(this.txtInPadLocX);
            this.grpSetup.Controls.Add(this.lblCalPow);
            this.grpSetup.Controls.Add(this.lblCalBe);
            this.grpSetup.Controls.Add(this.label5);
            this.grpSetup.Controls.Add(this.label4);
            this.grpSetup.Controls.Add(this.label3);
            this.grpSetup.Controls.Add(this.btnCalibrate);
            this.grpSetup.Controls.Add(this.label2);
            this.grpSetup.Controls.Add(this.label1);
            this.grpSetup.Location = new System.Drawing.Point(13, 13);
            this.grpSetup.Margin = new System.Windows.Forms.Padding(4);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Padding = new System.Windows.Forms.Padding(4);
            this.grpSetup.Size = new System.Drawing.Size(371, 120);
            this.grpSetup.TabIndex = 0;
            this.grpSetup.TabStop = false;
            this.grpSetup.Text = "Setup";
            // 
            // btnAdvancedOptions
            // 
            this.btnAdvancedOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAdvancedOptions.Location = new System.Drawing.Point(236, 22);
            this.btnAdvancedOptions.Name = "btnAdvancedOptions";
            this.btnAdvancedOptions.Size = new System.Drawing.Size(124, 27);
            this.btnAdvancedOptions.TabIndex = 22;
            this.btnAdvancedOptions.TabStop = false;
            this.btnAdvancedOptions.Text = "Advanced options";
            this.toolTip1.SetToolTip(this.btnAdvancedOptions, resources.GetString("btnAdvancedOptions.ToolTip"));
            this.btnAdvancedOptions.UseVisualStyleBackColor = true;
            this.btnAdvancedOptions.Click += new System.EventHandler(this.btnAdvancedOptions_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(16, 23);
            this.button5.TabIndex = 20;
            this.button5.TabStop = false;
            this.button5.Text = "<";
            this.toolTip1.SetToolTip(this.button5, "Paste both X and Y from the clipboard.");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.pasteToXYCal_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(16, 23);
            this.button4.TabIndex = 19;
            this.button4.TabStop = false;
            this.button4.Text = "<";
            this.toolTip1.SetToolTip(this.button4, "Paste both X and Y from the clipboard.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.pasteToXYPad_Click);
            // 
            // lblCalPow
            // 
            this.lblCalPow.Location = new System.Drawing.Point(329, 91);
            this.lblCalPow.Name = "lblCalPow";
            this.lblCalPow.Size = new System.Drawing.Size(32, 17);
            this.lblCalPow.TabIndex = 11;
            this.lblCalPow.Text = "0";
            this.lblCalPow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCalBe
            // 
            this.lblCalBe.Location = new System.Drawing.Point(329, 74);
            this.lblCalBe.Name = "lblCalBe";
            this.lblCalBe.Size = new System.Drawing.Size(32, 17);
            this.lblCalBe.TabIndex = 10;
            this.lblCalBe.Text = "0";
            this.lblCalBe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Power:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bearing:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calculated Offsets:";
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalibrate.Location = new System.Drawing.Point(11, 79);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(216, 28);
            this.btnCalibrate.TabIndex = 6;
            this.btnCalibrate.TabStop = false;
            this.btnCalibrate.Text = "Calibrate (0, 45, 20)";
            this.toolTip1.SetToolTip(this.btnCalibrate, "Calibrates the offsets using the provided coordinates.\r\nAssumes the probe was sen" +
        "t with:\r\n");
            this.btnCalibrate.UseVisualStyleBackColor = true;
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calibration Probe:";
            this.toolTip1.SetToolTip(this.label2, "X/Y Coordinates where the probe laned");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telepad Location:";
            this.toolTip1.SetToolTip(this.label1, "X/Y Coordinates of the telepad itself");
            // 
            // btnUsesAdd
            // 
            this.btnUsesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUsesAdd.Location = new System.Drawing.Point(288, 278);
            this.btnUsesAdd.Name = "btnUsesAdd";
            this.btnUsesAdd.Size = new System.Drawing.Size(23, 23);
            this.btnUsesAdd.TabIndex = 14;
            this.btnUsesAdd.TabStop = false;
            this.btnUsesAdd.Text = "+";
            this.toolTip1.SetToolTip(this.btnUsesAdd, "Press the + button each time you actually use the teleporter. You will need to re" +
        "calibrate it around 30-40 teleportations.");
            this.btnUsesAdd.UseVisualStyleBackColor = true;
            this.btnUsesAdd.Visible = false;
            this.btnUsesAdd.Click += new System.EventHandler(this.btnUsesAdd_Click);
            // 
            // lblUses
            // 
            this.lblUses.BackColor = System.Drawing.Color.Transparent;
            this.lblUses.Location = new System.Drawing.Point(256, 281);
            this.lblUses.Name = "lblUses";
            this.lblUses.Size = new System.Drawing.Size(23, 17);
            this.lblUses.TabIndex = 13;
            this.lblUses.Text = "0";
            this.lblUses.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.lblUses, "Press the + button each time you actually use the teleporter. You will need to re" +
        "calibrate it around 30-40 teleportations.");
            this.lblUses.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(209, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uses:";
            this.toolTip1.SetToolTip(this.label6, "Press the + button each time you actually use the teleporter. You will need to re" +
        "calibrate it around 30-40 teleportations.");
            this.label6.Visible = false;
            // 
            // grpCompute
            // 
            this.grpCompute.BackColor = System.Drawing.Color.Transparent;
            this.grpCompute.Controls.Add(this.button6);
            this.grpCompute.Controls.Add(this.btnCalculate);
            this.grpCompute.Controls.Add(this.txtInDstY);
            this.grpCompute.Controls.Add(this.label8);
            this.grpCompute.Controls.Add(this.txtInDstX);
            this.grpCompute.Enabled = false;
            this.grpCompute.Location = new System.Drawing.Point(13, 140);
            this.grpCompute.Name = "grpCompute";
            this.grpCompute.Size = new System.Drawing.Size(206, 104);
            this.grpCompute.TabIndex = 1;
            this.grpCompute.TabStop = false;
            this.grpCompute.Text = "Compute";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(16, 23);
            this.button6.TabIndex = 21;
            this.button6.TabStop = false;
            this.button6.Text = "<";
            this.toolTip1.SetToolTip(this.button6, "Paste both X and Y from the clipboard.");
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.pasteToXYDst_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(10, 59);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(189, 33);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Calculate the necessary values to reach the introduced destination.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnCalculate_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Destination:";
            this.toolTip1.SetToolTip(this.label8, "X/Y Coordinates of the desired destination");
            // 
            // grpResult
            // 
            this.grpResult.BackColor = System.Drawing.Color.Transparent;
            this.grpResult.Controls.Add(this.btnCpyPower);
            this.grpResult.Controls.Add(this.label12);
            this.grpResult.Controls.Add(this.btnCpyElevation);
            this.grpResult.Controls.Add(this.btnCpyBearing);
            this.grpResult.Controls.Add(this.label11);
            this.grpResult.Controls.Add(this.label10);
            this.grpResult.Location = new System.Drawing.Point(225, 140);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(160, 107);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // btnCpyPower
            // 
            this.btnCpyPower.Location = new System.Drawing.Point(89, 78);
            this.btnCpyPower.Name = "btnCpyPower";
            this.btnCpyPower.Size = new System.Drawing.Size(60, 23);
            this.btnCpyPower.TabIndex = 8;
            this.btnCpyPower.Text = "0";
            this.toolTip1.SetToolTip(this.btnCpyPower, "Pressing this button will copy the power to the clipboard.");
            this.btnCpyPower.UseVisualStyleBackColor = true;
            this.btnCpyPower.Click += new System.EventHandler(this.btnCpyToCliboard_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Power:";
            // 
            // btnCpyElevation
            // 
            this.btnCpyElevation.Location = new System.Drawing.Point(89, 49);
            this.btnCpyElevation.Name = "btnCpyElevation";
            this.btnCpyElevation.Size = new System.Drawing.Size(60, 23);
            this.btnCpyElevation.TabIndex = 7;
            this.btnCpyElevation.Text = "0";
            this.toolTip1.SetToolTip(this.btnCpyElevation, "Pressing this button will copy the elevarion to the clipboard.");
            this.btnCpyElevation.UseVisualStyleBackColor = true;
            this.btnCpyElevation.Click += new System.EventHandler(this.btnCpyToCliboard_Click);
            // 
            // btnCpyBearing
            // 
            this.btnCpyBearing.Location = new System.Drawing.Point(89, 20);
            this.btnCpyBearing.Name = "btnCpyBearing";
            this.btnCpyBearing.Size = new System.Drawing.Size(60, 23);
            this.btnCpyBearing.TabIndex = 6;
            this.btnCpyBearing.Text = "0";
            this.toolTip1.SetToolTip(this.btnCpyBearing, "Pressing this button will copy the bearing to the clipboard.");
            this.btnCpyBearing.UseVisualStyleBackColor = true;
            this.btnCpyBearing.Click += new System.EventHandler(this.btnCpyToCliboard_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Elevation:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Bearing:";
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInstructions.Location = new System.Drawing.Point(12, 250);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(113, 27);
            this.btnInstructions.TabIndex = 14;
            this.btnInstructions.TabStop = false;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAbout.Location = new System.Drawing.Point(131, 250);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(88, 27);
            this.btnAbout.TabIndex = 15;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkOnTop
            // 
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.BackColor = System.Drawing.Color.Transparent;
            this.chkOnTop.Checked = true;
            this.chkOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnTop.Location = new System.Drawing.Point(317, 280);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(70, 21);
            this.chkOnTop.TabIndex = 21;
            this.chkOnTop.TabStop = false;
            this.chkOnTop.Text = "On top";
            this.toolTip1.SetToolTip(this.chkOnTop, "Keep this window always on top");
            this.chkOnTop.UseVisualStyleBackColor = false;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDirectory.Location = new System.Drawing.Point(225, 250);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(159, 27);
            this.btnDirectory.TabIndex = 6;
            this.btnDirectory.TabStop = false;
            this.btnDirectory.Text = "Coordinates History";
            this.toolTip1.SetToolTip(this.btnDirectory, "Pressing this button will copy the bearing to the clipboard.");
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblStatus.Location = new System.Drawing.Point(54, 281);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 15);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "Needs calibration";
            // 
            // txtInDstY
            // 
            this.txtInDstY.Location = new System.Drawing.Point(142, 30);
            this.txtInDstY.Name = "txtInDstY";
            this.txtInDstY.Size = new System.Drawing.Size(36, 23);
            this.txtInDstY.TabIndex = 5;
            this.txtInDstY.Text = "0";
            this.txtInDstY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInDstY, "Y Coordinate");
            this.txtInDstY.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInDstY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtInDstY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalculate_KeyUp);
            this.txtInDstY.Leave += new System.EventHandler(this.txtNonEmpty_Leave);
            // 
            // txtInDstX
            // 
            this.txtInDstX.Location = new System.Drawing.Point(102, 30);
            this.txtInDstX.Name = "txtInDstX";
            this.txtInDstX.Size = new System.Drawing.Size(36, 23);
            this.txtInDstX.TabIndex = 4;
            this.txtInDstX.Text = "0";
            this.txtInDstX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInDstX, "X Coordinate");
            this.txtInDstX.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInDstX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtInDstX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalculate_KeyUp);
            this.txtInDstX.Leave += new System.EventHandler(this.txtNonEmpty_Leave);
            // 
            // txtInCalLocY
            // 
            this.txtInCalLocY.Location = new System.Drawing.Point(174, 50);
            this.txtInCalLocY.Name = "txtInCalLocY";
            this.txtInCalLocY.Size = new System.Drawing.Size(35, 23);
            this.txtInCalLocY.TabIndex = 3;
            this.txtInCalLocY.TabStop = false;
            this.txtInCalLocY.Text = "0";
            this.txtInCalLocY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInCalLocY, "Y Coordinate");
            this.txtInCalLocY.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInCalLocY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtInCalLocY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            this.txtInCalLocY.Leave += new System.EventHandler(this.txtNonEmpty_Leave);
            // 
            // txtInCalLocX
            // 
            this.txtInCalLocX.Location = new System.Drawing.Point(136, 50);
            this.txtInCalLocX.Name = "txtInCalLocX";
            this.txtInCalLocX.Size = new System.Drawing.Size(35, 23);
            this.txtInCalLocX.TabIndex = 2;
            this.txtInCalLocX.TabStop = false;
            this.txtInCalLocX.Text = "0";
            this.txtInCalLocX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInCalLocX, "X Coordinate");
            this.txtInCalLocX.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInCalLocX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtInCalLocX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            this.txtInCalLocX.Leave += new System.EventHandler(this.txtNonEmpty_Leave);
            // 
            // txtInPadLocY
            // 
            this.txtInPadLocY.Location = new System.Drawing.Point(174, 24);
            this.txtInPadLocY.Name = "txtInPadLocY";
            this.txtInPadLocY.Size = new System.Drawing.Size(35, 23);
            this.txtInPadLocY.TabIndex = 1;
            this.txtInPadLocY.TabStop = false;
            this.txtInPadLocY.Text = "0";
            this.txtInPadLocY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInPadLocY, "Y Coordinate");
            this.txtInPadLocY.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInPadLocY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtInPadLocY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            this.txtInPadLocY.Leave += new System.EventHandler(this.txtNonEmpty_Leave);
            // 
            // txtInPadLocX
            // 
            this.txtInPadLocX.Location = new System.Drawing.Point(136, 24);
            this.txtInPadLocX.Name = "txtInPadLocX";
            this.txtInPadLocX.Size = new System.Drawing.Size(35, 23);
            this.txtInPadLocX.TabIndex = 0;
            this.txtInPadLocX.TabStop = false;
            this.txtInPadLocX.Text = "0";
            this.txtInPadLocX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtInPadLocX, "X Coordinate");
            this.txtInPadLocX.Enter += new System.EventHandler(this.txtFocus_Enter);
            this.txtInPadLocX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterDigits_KeyPress);
            this.txtInPadLocX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCalibrate_KeyUp);
            this.txtInPadLocX.Leave += new System.EventHandler(this.txtNonEmpty_Leave);
            // 
            // Telescience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ss13Telescience.Properties.Resources.ss13telebg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(397, 302);
            this.Controls.Add(this.chkOnTop);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnUsesAdd);
            this.Controls.Add(this.lblUses);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpCompute);
            this.Controls.Add(this.grpSetup);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 341);
            this.MinimumSize = new System.Drawing.Size(413, 341);
            this.Name = "Telescience";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceStation13 Telescience Companion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Telescience_FormClosing);
            this.Load += new System.EventHandler(this.Telescience2_Load);
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            this.grpCompute.ResumeLayout(false);
            this.grpCompute.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalBe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCalPow;
        private System.Windows.Forms.GroupBox grpCompute;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Button btnCpyPower;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCpyElevation;
        private System.Windows.Forms.Button btnCpyBearing;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUsesAdd;
        private System.Windows.Forms.Label lblUses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private TextBoxPaste txtInPadLocX;
        private TextBoxPaste txtInPadLocY;
        private TextBoxPaste txtInCalLocY;
        private TextBoxPaste txtInCalLocX;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private TextBoxPaste txtInDstY;
        private TextBoxPaste txtInDstX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnAdvancedOptions;
    }
}