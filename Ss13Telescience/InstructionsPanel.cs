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
    public partial class InstructionsPanel : Form {

        public enum documentTypes {
            Instructions,
            About
        }
        public documentTypes documentType = documentTypes.Instructions;
        public InstructionsPanel() {
            InitializeComponent();
        }


        private void InstructionsPanel_Activated(object sender, EventArgs e) {
            richTextBox1.Rtf = documentType == documentTypes.Instructions ? instructionsRtf : aboutRtf;

            if(documentType == documentTypes.Instructions) this.Text = "Instructions";
            else if(documentType == documentTypes.About) this.Text = "About";
        }

        #region Texts
        String instructionsRtf = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Arial;}{\f1\fnil\fcharset2 Symbol;}}
{\*\generator Riched20 6.3.9600}\viewkind4\uc1 
\pard\fs22\lang3082\par
\b First you need to calculate the offsets:\par

\pard 
{\pntext\f0 1.\tab}{\*\pn\pnlvlbody\pnf0\pnindent0\pnstart1\pndec{\pntxta.}}
\fi-360\li720\b0 Input the telepad (X, Y) coordinates in the Telepad Location fields.\b\par
{\pntext\f0 2.\tab}\b0 Set bearing = 0, elevation = 45, power = 30 in your telescience computer and send a GPS.\b\par
{\pntext\f0 3.\tab}\b0 Input the( X, Y ) coordinates of the GPS you just teleported in the Calibration Probe fields.\b\par
{\pntext\f0 4.\tab}\b0 Click the Calibrate button.\b\par

\pard\b0\par
* Alternatively you can open the Advanced Calibration window and manually input the offsets if you already have them (check Advanced Calibration section below). \par
\par
\b Then you can calculate coordinates:\b0\par
Once it is calibrated, you simply input the target( X, Y ) coordinates in the Destination fields and click the Calculate button.\par
\par
It will calculate the bearing, elevation and power needed to send something to the destination coordinates.\par
\par
Now you can copy the values from the Result panel into the telescience computer.\par
\par
\b Advanced calibration:\b0\par
With the Advanced options button you can set custom bearing, elevation and power to calculate the offset.\par
\par
You can also manually set the bearing and power offsets. This is very useful in case another player already calculated the offsets and shared them with you, or if you closed the program by accident and don't remember the coordinates where the first probe landed. This way you don't need to send a probe GPS or use the calibrate button.\par
But beaware! If the player who calculated the offsets is using a different calculator, the offset's sign may be inverted.\par
\par
\b Server selection:\par
\b0 Different servers may have different code to calculate telescience. If the server you are playing on is not on the list, use the default one. If that doesn't work for your server, report an issue to the github page so it can be added (or add it yourself, this is open source!).\par
\par
\b Tips:\par

\pard{\pntext\f1\'B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\'B7}}\fi-360\li720\b0 The numbers from the Calibrate button are the bearing, elevation and power used to send the GPS probe, in that order.\par
{\pntext\f1\'B7\tab}The results numbers are actually buttons. If you click them, the displayed value will be copied to your clipboard.\par
{\pntext\f1\'B7\tab}Read the tooltips. Almost everything in the app have a tooltip.\par
{\pntext\f1\'B7\tab}Check the On top checkbox to keep the window always on top of the game.\par
{\pntext\f1\'B7\tab}While the Calculate button is focused, you can press the keyboard keys 1,2 and 3 to copy the resulting bearing, elevation and power.\par
{\pntext\f1\'B7\tab}You can copy any coordinates directly from the game in any format and paste them directly in either of the X/Y coordinate fields.\line These are all valid examples: (123, 125) | 123, 125 | 123 125 | 123, 125, 1) | ((123  125 | etc.\par
}

 ";


        string aboutRtf = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Arial;}}
{\colortbl ;\red0\green0\blue255;}
{\*\generator Riched20 10.0.15063}\viewkind4\uc1 
\pard\qc\b\fs19\lang3082\par SpaceStation13 Telescience Companion v1.0\b0\fs22\par\par
\pard The goal of this application is to provide a fast interaction between the game (SpaceStation13) and the calculator, attempting to go from in-game coordinates to in-game bearing/elevation/power with the fewest mouse clicks and troubles.\par
\par
The calculation code was ported from RageAgainstheCondom's calculator: {{\field{\*\fldinst{HYPERLINK https://github.com/RageAgainstheCondom/SS13Telecoms-Paradise }}{\fldrslt{https://github.com/RageAgainstheCondom/SS13Telecoms-Paradise\ul0\cf0}}}}\f0\fs22\par
Minor changes were made like rounding and the ability to calculate the offsets with variable bearing/elevation/power.\par
The application's icon was taken from Paradise Station server.
\par
\par
This is an open source aplication, you can find it at github: https://github.com/Alriac/ss13TelescienceCompanion\par
Feel free to submit changes or use it to make your own calculator! \par
\par
\par
By Alriac\par\par
}
 ";



        #endregion

        /// <summary>
        /// Prevents form destruction for reusability.
        /// </summary>
        private void InstructionsPanel_FormClosing(object sender, FormClosingEventArgs e) {
            if(e.CloseReason != CloseReason.ApplicationExitCall) {
                e.Cancel = true;
                this.Hide();
            }
        }


    }
}
