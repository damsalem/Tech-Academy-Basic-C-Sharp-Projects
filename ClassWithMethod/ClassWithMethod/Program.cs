using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath div2 = new SimpleMath();

            Console.WriteLine("Please enter a number you want divided by 2");
            string userString = Console.ReadLine();
            Int32.TryParse(userString, out int aNum);

            div2.simpleMethod(aNum);
            Console.ReadLine();

            Console.WriteLine("Please enter a number you want to add 10 to" +
                "\nAnd that you want multiplied by 2");
            string userString2 = Console.ReadLine();
            Int32.TryParse(userString2, out int aNum2);

            div2.simpleMethod(aNum2, out int answer1, out int answer2);
            Console.ReadLine();

            Console.WriteLine("Finally, please enter a number you want multiplied by 3");
            string userString3 = Console.ReadLine();
            Int32.TryParse(userString3, out int aNum3);

            //This uses the static class
            Static.anotherMethod(aNum3, out int tomSawyer);
            Console.WriteLine(tomSawyer);
            Console.ReadLine();
        }
    }
}
