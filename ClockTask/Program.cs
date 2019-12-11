using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockTask {
    class Program {

        static void Main(string[] args) {

            Intro intro = new Intro();
            Engine engine = new Engine();
            Minutes Min = new Minutes();
            Hours H = new Hours();

            // Greetings and instructions
            intro.GreetUser();
            intro.Instructions();

            // You can write your own time and set it
            int hours = engine.TakeHoursNumber();
            H.Hour = hours;
            int minutes = engine.TakeMinutesNumber();
            Min.Minute = minutes;

            Console.WriteLine("{0}H:{1}MIN", hours, minutes);

            /* Methods count angle of arrows
               TotalArrowAngleHour(minutes) takes a parameter 
               to count extra angle that adds for hour arrow after each minute passed in that hour
               TotalArrowAngleMinute() counts angle of minute arrow from starting point - 0 degrees*/
            H.TotalHourAngle(minutes);
            Min.TotalMinuteAngle();

            // Applies total angles and then sets into engine, to count positive angle between arrows 
            double totalHArrowAngle = H.HourAngleTotal;
            double totalMinArrowAngle = Min.MinuteAngleTotal;

            engine.HourArrowTotal = totalHArrowAngle;
            engine.MinuteArrowTotal = totalMinArrowAngle;

            // Print returned positive angle
            Console.WriteLine(engine.PositiveFinalAngle());

            Console.WriteLine("Press Enter to quit.");
            Console.ReadLine();

        }
    }
}
