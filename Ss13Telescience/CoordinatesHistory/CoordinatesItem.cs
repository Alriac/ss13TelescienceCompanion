using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ss13Telescience.CoordinatesHistory {
    class CoordinatesItem {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public double Bearing { get; set; }
        public double Elevation { get; set; }
        public int Power { get; set; }

        public override bool Equals(object obj) {
            if(obj is CoordinatesItem)
                return ( (CoordinatesItem)obj ).X == this.X && ( (CoordinatesItem)obj ).Y == this.Y;
            return false;
        }
    }
}
