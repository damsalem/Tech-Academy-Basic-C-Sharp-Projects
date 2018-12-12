using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsWithTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please enter a number for your age");
            int userAge = 0;
            bool validAge = false;
            try
            {
                validAge = Int32.TryParse(Console.ReadLine(), out userAge);
                if (userAge <= 0)
                {
                    throw new NumberException();
                }
                int thisYear = DateTime.Now.Year;
                int birthYear = thisYear - userAge;
                Console.WriteLine("Because you are {0} years old, " +
                    "it looks like you were born in {1}.", userAge, birthYear);
                Console.ReadLine();
            }
            catch (NumberException)
            {
                Console.WriteLine("Hey, you didn't enter a number above 0, I quit!");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an error occurred. " +
                    "Please contact your system administrator.");
                Console.ReadLine();
            }
        }
    }
}
