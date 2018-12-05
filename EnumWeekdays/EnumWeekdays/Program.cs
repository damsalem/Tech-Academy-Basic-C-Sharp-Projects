using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeekdays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week");
            string userData = Console.ReadLine();

            bool wrongAnswer = false;

            while (!wrongAnswer)
            {
                try
                {
                    //Enum.TryParse(userData, true, out DayOfWeek userDay);
                    DayOfWeek userDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userData, true);
                    wrongAnswer = true;
                    Console.WriteLine("It looks like you wrote" + " " + userDay + ".");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    userData = Console.ReadLine();
                }
            }
        }
    }
}
