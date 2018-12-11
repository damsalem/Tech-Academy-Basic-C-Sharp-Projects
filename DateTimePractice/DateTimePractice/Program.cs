using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date and time is: " + DateTime.Now);
            Console.WriteLine("\nPlease enter a number of hours you want it to be in the future.");
            int futureHour = Int32.Parse(Console.ReadLine());
            Console.WriteLine("In {0} hours it will be: {1}", futureHour, DateTime.Now.AddHours(futureHour));
            Console.ReadLine();
        }
    }
}
