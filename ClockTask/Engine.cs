using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask {
    class Engine {

        public double totalAngleDifference;

        public double hourArrowTotal;

        public double minuteArrowTotal;

        public Engine() {

        }

        // Takes from Program class angles and sets 
        public void set_HourArrowTotal(double angle)
        {
            this.hourArrowTotal = angle;
        }

        public void set_MinuteArrowTotal(double angle)
        {
            this.minuteArrowTotal = angle;
        }

        /* This method let's user to write a hour number in console
         * Then it checks if it is a valid number
         * If valid number then it returns hour
         * If not goes back to the beginning of this method
         * By calling it self as a return
         */ 
        public int TakeHoursNumber()
        {
            Console.WriteLine("Write hour arrow value: (from 1 to 12): ");

            string value = Console.ReadLine();

            int hour;

            bool success = Int32.TryParse(value, out hour);

            if(success && (hour >= 1 && hour <= 12))
            {
                return hour;
            } else
            {
                Console.WriteLine("Not a valid number, try again:");
                return TakeHoursNumber();
            }
        }

        /* This method let's user to write a minute number in console
         * Then it checks if it is a valid number
         * If valid number then it returns minute
         * If not goes back to the beginning of this method
         * By calling it self as a return
         */
        public int TakeMinutesNumber()
        {
            Console.WriteLine("Write minutes: (from 0 to 59): ");
            string value = Console.ReadLine();

            int minute;

            bool success = Int32.TryParse(value, out minute);

            if (success && (minute >= 0 && minute < 59))
            {
                return minute;
            } else
            {
                Console.WriteLine("Not a valid number, try again:");
                return TakeMinutesNumber();
            }
        }

        // This method will bring back a positive angle of two arrows
        public double PositiveFinalAngle() {

            // Angle diference
            totalAngleDifference = hourArrowTotal - minuteArrowTotal;

            if(totalAngleDifference < 0) {
                totalAngleDifference *= -1;
            }

            return totalAngleDifference;

        }
    }
}
