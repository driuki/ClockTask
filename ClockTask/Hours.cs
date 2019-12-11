using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask {

    class Hours {

        // Min angle of one hour is: 360 / 12 - degrees
        public const int HourAngle = 30;
        // Angle movement of hour arrow by one minute is: HourAngle / 60 - degrees
        public const double HourAngleShiftByMinute = 0.5;

        public int hour;

        public double hourAngleTotal;

        public Hours() {
        }

        public double HourAngleTotal
        {
            get { return hourAngleTotal; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        /* Method takes parameter of minutes and counts total angle 
           of hour arrow from starting point - 0 degrees*/
        public void TotalHourAngle(double minutes) {
            hourAngleTotal = (this.hour * HourAngle) + (minutes * HourAngleShiftByMinute);
        }

    }
}
