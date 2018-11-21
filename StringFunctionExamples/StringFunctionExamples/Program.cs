using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "The man said \"Hello\" to me.";
            string newLine = "Here is one line. \n And this is a new line.";
            string tab = "\t Hello from a tabbed new line.";
            string fileName1 = "C:\\Desktop\\New Folder";
            string fileName2 = @"C:\Desktop\New Folder2";
            
            //check for true/false of string inclusions
            bool trueOrFalse = quote.Contains("said");
            trueOrFalse = quote.EndsWith("me");

            //character length
            int length = quote.Length;

            //convert strings to case text
            quote = quote.ToUpper();
            quote = quote.ToLower();

            //Console.WriteLine(quote);
            //Console.WriteLine(newLine);
            //Console.WriteLine(tab);
            //Console.WriteLine(fileName1);
            //Console.WriteLine(fileName2);
            //Console.WriteLine(length);

            //String builder is a dynamic object that acts as a buffer 
            //to expand/shrink strings without a loss of performance
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Dani");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
