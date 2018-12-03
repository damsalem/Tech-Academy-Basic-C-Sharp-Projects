using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalParameter twoNums = new OptionalParameter();

            Console.WriteLine("I'm going to combine two numbers you enter, then multiply them by 2." + 
                "\nPlease enter your first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Now enter your second number, this is optional.");
            string inputString = Console.ReadLine();

            //Tries to parse "inputString" and if no value, twoNums.singleOrDoubleParam plugs in a "0"
            Int32.TryParse(inputString, out int num2);
            
            int answer = twoNums.singleOrDoubleParam(requiredInt: num1, optionalInt: num2);
            
            Console.WriteLine("(" + num1 + " + " + num2 + ")" + " X 2 = " + answer);
            Console.ReadLine();


        }
    }
}
