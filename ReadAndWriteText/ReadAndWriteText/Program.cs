using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndWriteText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number you'd like recorded in a .txt file");
            string userText = Console.ReadLine();
            using (StreamWriter textFile = new StreamWriter(@"C:\Users\Dani\Desktop\Basic-C#\ReadAndWriteText\txt.log"))
            {
                textFile.WriteLine(userText);
            }
            string x = File.ReadAllText(@"C:\Users\Dani\Desktop\Basic-C#\ReadAndWriteText\txt.log");
            Console.WriteLine("After looking at your document, it looks like you wrote: " + x);
            Console.ReadLine();
        }
    }
}
