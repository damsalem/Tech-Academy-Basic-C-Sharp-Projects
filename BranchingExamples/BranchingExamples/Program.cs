using System;

namespace BranchingExamples
{
    class Program
    {
        static void Main()
        {
            string name = "Erik";
            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is Brett");
            }
            else if (name == "Adam")
            {
                Console.WriteLine("Your name is Adam");
            }
            else
                Console.WriteLine("I don't know you");
            Console.ReadLine();
        }
        
    }
}
