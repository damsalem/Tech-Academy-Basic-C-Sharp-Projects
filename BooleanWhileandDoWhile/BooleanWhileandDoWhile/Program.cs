using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanWhileandDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /////
            ///WHILE loop
            /////
            Console.WriteLine("Try to guess my favorite color");
            string color = Console.ReadLine();
            bool guess = color == "empty";

            while (!guess)
            {
                switch (color)
                {
                    case "silver":
                        Console.WriteLine("Ooo shiny! You're getting closer! Try again.");
                        color = Console.ReadLine();
                        break;

                    case "white":
                        Console.WriteLine("Bleh. Boring! Try again.");
                        color = Console.ReadLine();
                        break;

                    case "blue":
                        Console.WriteLine("Boring! Try again.");
                        color = Console.ReadLine();
                        break;

                    case "black":
                        Console.WriteLine("That's too dark. Try again.");
                        color = Console.ReadLine();
                        break;

                    case "gold":
                        Console.WriteLine("Wow! That's it!");
                        guess = true;
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Hmmm. Nope! Try again.");
                        color = Console.ReadLine();
                        break;
                }
            }

            /////
            ///DO WHILE LOOP
            ///
            Console.WriteLine("What is your favorite city abbreviation?");
            string city = Console.ReadLine();
            bool aGuess = city == "NYC";

            do
            {
                switch (city.ToLower())
                {
                    case "nyc":
                        Console.WriteLine("Hey, that's my favorite city too!");
                        aGuess = true;
                        Console.ReadLine();
                        break;

                    case "pdx":
                        Console.WriteLine("Yeah, that one's okay.");
                        Console.WriteLine("Try again.");
                        city = Console.ReadLine();
                        break;

                    case "atl":
                        Console.WriteLine("I guess, it's in a lot of songs.");
                        Console.WriteLine("Try again.");
                        city = Console.ReadLine();
                        break;

                    case "sfo":
                        Console.WriteLine("Sure, kind of like UFO");
                        Console.WriteLine("Try again.");
                        city = Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Meh...");
                        Console.WriteLine("Try again.");
                        city = Console.ReadLine();
                        break;
                }
            }
            while (!aGuess);
            
        }
    }
}
