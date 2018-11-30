using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addition method
            Console.WriteLine("Enter some number you want to add 10 to:");
            int x = Int32.Parse(Console.ReadLine());

            SomeMath justMath = new SomeMath();
            int sum = justMath.simpleAddition(x);

            Console.WriteLine(sum);

            //Subtraction method
            Console.WriteLine("Now enter some number you want to subtract 1 from:");
            int y = Int32.Parse(Console.ReadLine());
            
            int difference = justMath.simpleSubtraction(y);

            Console.WriteLine(difference);

            //Multiplication method
            Console.WriteLine("Finally, enter some number you want to multiply 2 with:");
            int z = Int32.Parse(Console.ReadLine());

            int product = justMath.simpleMultiplication(z);

            Console.WriteLine(product);
            Console.ReadLine();
        }
    }
}
