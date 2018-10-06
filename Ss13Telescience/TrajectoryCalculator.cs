using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss13Telescience.TrajectoryCalculation {
    /// <summary>
    /// Base class for calculation and calibration. Extend for aditional servers that use different calculations.
    /// </summary>
    public abstract class TrajectoryCalculator {

        public virtual int powerOffset { get; set; }

        public virtual int bearingOffset { get; set; }

        // Calculations options list
        private static CalculationServerOption[] _CalculationOptionsList = new CalculationServerOption[] {
                new CalculationServerOption{CalculationName = "Default calculation", CalcType = TrajectoryCalculator.CalculationType.Default},
                new CalculationServerOption{CalculationName = "Paradise Server", CalcType = TrajectoryCalculator.CalculationType.Default}, // Default works on paradise.
                // ... Add more servers here even if they use the default one. So players know this work on the server they play.
                };
        /// <summary>
        /// List of available calculations for different servers.
        /// </summary>
        public static CalculationServerOption[] CalculationOptionsList {
            get {
                return _CalculationOptionsList;
            }
        }

        // Calculation results
        public virtual double resBearing { get; set; }
        public virtual int resPower { get; set; }
        public virtual double resElevation { get; set; }

        // Telepad location
        protected int padX = 0;
        protected int padY = 0;
        // GPS probe location
        protected int calX = 0;
        protected int calY = 0;

        // Settings used to send the GPS probe
        protected double calPower = 20;
        protected double calBearing = 0;
        protected double calElevation = 45;

        // Status result from last operation.
        public string status = "Needs calibration";

        /// <summary>
        /// Calculates both power and bearing offset assuming that the user enters the x,y value of the GPS once its sent with the current calibration values.
        /// </summary>
        public abstract void calcOffsets();
        /// <summary>
        /// Is the method that is called in order to perform all calculations for a single target, always assuming that the starting point is Padx,Pady
        /// </summary>
        /// <returns>True if everything went fine.</returns>
        public abstract bool calcAll(int xTarget, int yTarget);

        /// <summary>
        /// Manually sets the offsets instead of calculate them.
        /// </summary>
        public void setOffsets(int bearingOffset, int powerOffset) {
            this.bearingOffset = bearingOffset;
            this.powerOffset = powerOffset;
        }

        protected double toRadian(double angle) {
            return angle * ( Math.PI / 180.0 );
        }

        protected double fromRadian(double angle) {
            return angle * ( 180.0 / Math.PI );
        }

        /// <summary>
        /// Calculation types. Was tested on paradise server, but maybe other servers can use this one.
        /// </summary>
        public enum CalculationType {
            Default = 0
        }
        /// <summary>
        /// Creates a new calculator of the selected type.
        /// </summary>
        public static TrajectoryCalculator createCalculator(int padX, int padY, int calX, int calY, int calPower, float calBearing, float calElevation, CalculationType CalcType) {
            switch ( CalcType ) {
                case CalculationType.Default:
                default:
                    return new TrajectoryCalculatorParadise( padX, padY, calX, calY, calPower, calBearing, calElevation );
            }
        }

        public class CalculationServerOption {
            public TrajectoryCalculator.CalculationType CalcType { get; set; }
            public string CalculationName { get; set; }
            public override string ToString() {
                return CalculationName;
            }
        }

    }
}
