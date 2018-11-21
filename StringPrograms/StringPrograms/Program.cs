using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press [Enter] to display 3 concatenated strings within ||");
            Console.ReadLine();

            string fName = "Dani";
            string lName = "Amsalem";
            string nationality = "American";

            Console.WriteLine("My name is |" + fName + "| |" + lName + "| and I am an |" + nationality + "|");
            Console.WriteLine("Next, you will see a string of words. Press [Enter] to continue.");
            Console.ReadLine();

            string favFood = "My favorite food is a Korean dish called \"Gopchang Bokkum\"";
            Console.WriteLine(favFood);
            Console.WriteLine("Press [Enter] to display the same string all in uppercase");
            Console.ReadLine();

            favFood = favFood.ToUpper();
            Console.WriteLine(favFood);
            Console.WriteLine("Next, you will see Stringbuilder build a paragraph of text, once sentence at a time.");
            Console.WriteLine("Press [Enter] to continue;");
            Console.ReadLine();


        }
    }
}
