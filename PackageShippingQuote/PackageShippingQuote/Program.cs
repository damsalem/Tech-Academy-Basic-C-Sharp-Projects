using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weight?");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("I'm sorry, but your package is too heavy to be shipped via Package Express. Good luck!");
            }
            else
            {
                Console.WriteLine("Excellent, what is your package's width?");
            }

            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you, and what is your package's height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you, and finally, what is your package's length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int totalDimensions = packageWidth + packageHeight + packageLength;
            if (totalDimensions > 50)
            {
                Console.WriteLine("I'm sorry, but your package is too large to be shipped via Package Express. Good luck!");
            }

            int dimensionsWeight = totalDimensions * packageWeight;
            int acceptedSize = dimensionsWeight / 100;
            decimal shippingCost = acceptedSize;

            Console.WriteLine("Okay, sour shipping cost is: $" + shippingCost);
            Console.ReadLine();
        }
    }
}
