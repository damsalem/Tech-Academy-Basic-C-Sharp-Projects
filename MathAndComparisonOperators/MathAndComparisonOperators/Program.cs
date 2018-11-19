using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("10 - 5 = " + difference);
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine("10 X 5 - " + product);
            //Console.ReadLine();

            //int quotient = 100 / 17;
            //Console.WriteLine("100 divided by 5 = " + quotient);
            //Console.ReadLine();

            //double quotientRemainder = 100.0 / 17.0;
            //Console.WriteLine("100 divided by 5 = " + quotientRemainder);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool TrueOrFalse = 12 > 5;
            //Console.WriteLine(TrueOrFalse.ToString());
            //Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 70;
            //bool isWarm = currentTemperature >= roomTemperature;
            bool isWarm = currentTemperature == roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();


        }
    }
}
