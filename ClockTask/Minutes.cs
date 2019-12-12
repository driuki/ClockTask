using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask {

    class Minutes {

        // Min angle of one minute is: 360 / 60 degrees
        public const int MINUTEANGLE = 6;

        public int Minute { get; set; }

        public double MinuteAngleTotal { get; set; }

        public Minutes() {
        }

      //  public double MinuteAngleTotal
      //  {
      //      get { return minuteAngleTotal; }
      //  }

       // public int Minute
       // {
      //      get { return minute; }
      //      set { minute = value; }
       // }

        // Method that counts total minute arrow angle 
        public void TotalMinuteAngle() {
            MinuteAngleTotal = Minute * MINUTEANGLE;
        }

    }

}
