using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ss13Telescience {
    /// <summary>
    /// Custom textbox that supports text pasting event.
    /// </summary>
    class TextBoxPaste : TextBox {

        private const int WM_PASTE = 0x0302;
        private string pasted = ""; // Keep the pasted text to access it from the event handler.


        private EventHandler onPaste;
        public event EventHandler Paste {
            add {
                onPaste += value;
            }
            remove {
                onPaste -= value;
            }
        }

        protected override void WndProc(ref Message m) {
            if(m.Msg != WM_PASTE) {
                base.WndProc( ref m );
            } else {
                // If text was pasted, save it and fire the event.
                if(Clipboard.ContainsText()) {
                    pasted = Clipboard.GetText();
                    if(onPaste != null)
                        onPaste( this, new EventArgs() );
                }
            }
        }


        public String GetPastedText() {
            return pasted;
        }
    }


}
