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
            decimal packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("I'm sorry, but your package is too heavy to be shipped via Package Express. Good luck!");
            }
            else
            {
                Console.WriteLine("Excellent, what is your package's width?");
            }

            decimal packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you, and what is your package's height?");
            decimal packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you, and finally, what is your package's length?");
            decimal packageLength = Convert.ToInt32(Console.ReadLine());

            decimal totalDimensions = packageWidth + packageHeight + packageLength;

            bool acceptableSize = false;

            decimal dimensionsWeight = totalDimensions * packageWeight;
            decimal acceptedSize = dimensionsWeight / 100;
            decimal shippingCost = acceptedSize;

            do
            {
                if (totalDimensions > 50)
                {
                    Console.WriteLine("I'm sorry, but your package is too large to be shipped via Package Express. Good luck!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Okay, your shipping cost is: $" + shippingCost);
                    acceptableSize = true;
                    Console.ReadLine();
                }
            } while (!acceptableSize);

            
        }
    }
}
