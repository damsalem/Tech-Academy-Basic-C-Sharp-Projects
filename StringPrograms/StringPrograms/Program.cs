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

            StringBuilder iWillBuild = new StringBuilder();
            iWillBuild.Append("So you know who I am, my nationality, and my favorite dish.");
            Console.WriteLine(iWillBuild);
            Console.ReadLine();

            iWillBuild.Append("\nBut did you know that my mother is Korean and my father is a Moroccan-Jew born in Jerusalem?");
            Console.WriteLine(iWillBuild);
            Console.ReadLine();

            iWillBuild.Append("\nAnd did you know that I met my wife online, even though we had mutual friends, had gone to 3 of the same schools, \nand our parents knew each other?");
            Console.WriteLine(iWillBuild);
            Console.ReadLine();

            iWillBuild.Append(" Finally, it's worth mentioning that I am a big blockchain fan.");
            Console.WriteLine(iWillBuild);
            Console.ReadLine();
        }
    }
}
