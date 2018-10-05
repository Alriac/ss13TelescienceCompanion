using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss13Telescience {
    class TrajectoryCalculator {

        public int powerOffset = 0;
        public int bearingOffset = 0;

        private int Dx = 0;
        private int Dy = 0;
        private int distance = 0;

        public double resBearing = 0;
        public int resPower = 0;
        public double resElevation = 0;

        private int padX = 0;
        private int padY = 0;
        private int calX = 0;
        private int calY = 0;

        public double calPower = 20;
        public double calBearing = 0;
        public double calElevation = 45;

        public string status = "Needs calibration"; // Status result from last operation.

        public TrajectoryCalculator(int padX, int padY, int calX, int calY, int calPower, float calBearing, float calElevation) {
            this.padX = padX;
            this.padY = padY;
            this.calX = calX;
            this.calY = calY;
            this.calPower = calPower;
            this.calBearing = calBearing;
            this.calElevation = calElevation;
        }

        /// <summary>
        /// Calculates the X and Y displacement.
        /// </summary>
        public void calcDXDY(int xTarget, int yTarget) {
            Dx = xTarget - padX;
            Dy = yTarget - padY;
        }

        /// <summary>
        /// Calculates the  the distance traveled
        /// </summary>
        public void calcDistance() {
            double temp = Math.Sqrt( ( Math.Pow( Dx, 2 ) + Math.Pow( Dy, 2 ) ) );
            distance = (int)Math.Round( temp );
        }

        /// <summary>
        /// Calculates both power and bearing offset assuming that the user enters the x,y value of the GPS once its sent with the current calibration values.
        /// </summary>
        public void calcOffsets() {
            calcDXDY( calX, calY );
            calcDistance();
            double temp = fromRadian( Math.Atan2( Dx, Dy ) ) - calBearing;
            if(Dx < 0) temp += 360;
            bearingOffset = (int)Math.Round( temp );

            double temp2 = Math.Sin( toRadian( 2 * calElevation ) );
            double squared = Math.Sqrt( ( 10 * distance ) / temp2 );
            powerOffset = (int)Math.Round( calPower - squared );
        }

        /// <summary>
        /// Calculates the bearing, with the offset added to it and saves it for further use.
        /// NOTE: The reason that these if, else ifs exist is beacause paradise is backwards and works on a bearing degree trejectory instead of a circle one.      Dont question it much, it works.
        /// </summary>
        /// <returns>False if shit hits the fan</returns>
        public bool calcBearing() {
            // inverts the offset, to allow the angle to reach the desired value (ex, with an offset of -3 you need to ADD it to the angle so it goes down to the desired than to subtract it)
            int tempOffset = bearingOffset * -1;
            if(Dx == 0 && Dy < 0) {
                resBearing = 180 + tempOffset;
            } else if(Dx == 0 && Dy > 0) {
                resBearing = 0 + tempOffset;
            } else if(Dx > 0 && Dy >= 0) {
                resBearing = fromRadian( Math.Atan2( Dx, Dy ) ) + tempOffset;
            } else if(Dx > 0 && Dy < 0) {
                resBearing = fromRadian( Math.Atan2( Dx, Dy ) ) + tempOffset;
            } else if(Dx < 0 && Dy > 0) {
                resBearing = fromRadian( Math.Atan2( Dx, Dy ) ) + 360 + tempOffset;
            } else if(Dx < 0 && Dy <= 0) {
                resBearing = fromRadian( Math.Atan2( Dx, Dy ) ) + 360 + tempOffset;
            } else {
                status = "Error calculating the bearing";
                return false;
            }
            // if the bearing is -, due to the offset, add 360 to make it usable.
            if(resBearing < 0) {
                resBearing += 360;
            }
            return true;
        }

        /// <summary>
        /// Calculates the needed power, adjusting for offset. Needs to be hardcoded to account for the "random" incriments of power available (That shift from 5-10 to 20 to 25 is giving me nightmares).
        /// </summary>
        /// <returns>False if a) the power is over 100 or b) something goes awfully wrong. True otherwise.</returns>
        public bool calcPower() {
            double powertemp = ( Math.Sqrt( distance * 10 ) ) + powerOffset;
            if(powertemp <= 5.0) {
                resPower = 5;
            } else if(powertemp <= 10.0) {
                resPower = 10;
            } else if(powertemp <= 20.0) {
                resPower = 20;
            } else if(powertemp <= 25.0) {
                resPower = 25;
            } else if(powertemp <= 30.0) {
                resPower = 30;
            } else if(powertemp <= 40.0) {
                resPower = 40;
            } else if(powertemp <= 50.0) {
                resPower = 50;
            } else if(powertemp <= 80.0) {
                resPower = 80;
            } else if(powertemp <= 100.0) {
                resPower = 100;
            } else {
                status = "Error calculating the power";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Calculates the elevation needed, precondition: needs to have calculated power.
        /// </summary>
        public void calcElevation() {
            double distanceMax = Math.Pow( ( (double)resPower - (double)powerOffset ), 2 ) / 10;
            double elevationtemp = fromRadian( Math.Asin( (double)distance / (double)distanceMax ) ) / 2.0;
            resElevation = Math.Floor( elevationtemp * 1e4 ) / 1e4;
        }

        /// <summary>
        /// Is the method that is called in order to perform all calculations for a single target, always assuming that the starting point is Padx,Pady
        /// </summary>
        /// <returns>True if everything went fine.</returns>
        public bool calcAll(int xTarget, int yTarget) {
            bool result = true;
            calcDXDY( xTarget, yTarget );
            calcDistance();
            result &= calcBearing();
            result &= calcPower();
            calcElevation();
            if(result)
                status = "Calculation done! Check the results panel";
            return result;
        }

        /// <summary>
        /// Manually sets the offsets instead of calculate them.
        /// </summary>
        public void setOffsets(int bearingOffset, int powerOffset) {
            this.bearingOffset = bearingOffset;
            this.powerOffset = powerOffset;
        }

        private double toRadian(double angle) {
            return angle * ( Math.PI / 180.0 );
        }

        private double fromRadian(double angle) {
            return angle * ( 180.0 / Math.PI );
        }
    }
}
