using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 2;

            /////
            //You could skip the DO WHILE loop and just set the "number" variable to anything but 2
            /////

            /////
            //These two are the same
            /////
            //while (isGuessed == false)
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62, try again!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29, try again!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55, try again!");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2, well done!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Sorry, you're wrong.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            
            Console.ReadLine();
        }
    }
}
