using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainingConstrAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, please tell me your name.");
            string userName = Console.ReadLine();
            const int year = 1981;
            var progName = "TRS-80";
            Console.WriteLine("Welcome {0}. Now let me take you back to {1} " +
                "when the {2} was in heavy use.", userName, year, progName);
            Console.WriteLine("This early computer was built from a " +
                "Radioshack kit and used a black and white TV for its display." +
                "\nThis old computer didn't even have a built-in hard-drive! " +
                "Instead, it used cassettes as memory storage devices.");
            Console.WriteLine("\nNow it's your turn. Please enter your own name " +
                "for a computer you think should have existed in 1990.");
            string userText = Console.ReadLine();
            OldPcs userPc = new OldPcs(userText);
            Console.WriteLine("Excellent! So your computer would have been " +
                "a {0} {1}.", userPc.yearMade, userPc.computerName);
            Console.ReadLine();
        }
    }
}
