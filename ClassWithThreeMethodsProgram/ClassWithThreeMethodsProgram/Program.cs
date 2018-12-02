using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithThreeMethodsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion adjustData = new Conversion();

            Console.WriteLine("Please enter a number you want to add 5 to");
            int userNum1 = Int32.Parse(Console.ReadLine());

            int answer1 = adjustData.simpleMethod(userNum1);
        }
    }
}
