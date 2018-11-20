using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanCarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Write \"True\" or \"False\".");
            /////This works
            bool dui = Boolean.Parse(Console.ReadLine());

            /////This also works
            //string duiInput = Console.ReadLine();
            //bool dui = Convert.ToBoolean(duiInput);

            Console.WriteLine("How many speeding tickets do you have?");
            string numberTickets = Console.ReadLine();
            int numTickets = Int32.Parse(numberTickets);

            bool qualified = (age >= 15 && (dui == false) && numTickets <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
