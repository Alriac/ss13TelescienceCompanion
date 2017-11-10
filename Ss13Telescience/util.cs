using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ss13Telescience {
    class Util {

        public static int readInt(TextBoxBase txt, int def = 0) {
            int read;
            if(int.TryParse( txt.Text, out read )) return read;
            return def;
        }
        public static int readInt(ComboBox txt, int def = 0) {
            int read;
            if(int.TryParse( txt.Text, out read )) return read;
            return def;
        }

    }
}
