using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask {

    class Minutes {

        // Min angle of one minute is: 360 / 60 degrees
        public const int MinuteAngle = 6;

        public int minute;

        public double minuteAngleTotal;

        public Minutes() {
        }

        public void set_Minute(int minute) {
            this.minute = minute;
        }

        public double get_Minute() {
            return minute;
        }

        public double get_MinuteAngleTotal()
        {
            return minuteAngleTotal;
        }

        // Method that counts total minute arrow angle 
        public void TotalMinuteAngle() {
            minuteAngleTotal = this.minute * MinuteAngle;
        }

    }

}
