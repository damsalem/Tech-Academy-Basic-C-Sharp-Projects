using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithThreeMethodsProgram
{
    class Program
    {
        //This program calls 3 classes by the same name.
        //It uses "overloading" to deal with that.
        //Because the methods use different data types, just inputting that will separate them
        static void Main(string[] args)
        {
            Conversion adjustData = new Conversion();

            Console.WriteLine("Please enter a number you want to add 5 to");
            int userNum1 = Int32.Parse(Console.ReadLine());

            //overload for method 1
            int answer1 = adjustData.simpleMethod(userNum1);
            Console.WriteLine(answer1);
            Console.ReadLine();


            Console.WriteLine("Now, please enter a number you want to multiply by 2");
            decimal userNum2 = decimal.Parse(Console.ReadLine());

            //overload for method 2
            decimal answer2 = adjustData.simpleMethod(userNum2);
            Console.WriteLine(answer2);
            Console.ReadLine();


            Console.WriteLine("Finally, please enter either numbers or words you want multiplied by 5" +
                "\nP.S. words will be ignored and 5 will be displayed.");
            string userNum3 = Console.ReadLine();

            //overload for method 3
            int answer3 = adjustData.simpleMethod(userNum3);
            Console.WriteLine(answer3);
            Console.ReadLine();
        }
    }
}
