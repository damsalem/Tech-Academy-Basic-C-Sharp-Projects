using System;

namespace BranchingExamples
{
    class Program
    {
        static void Main()
        {
            /////
            //IF branching
            /////
            //string name = "Brett";
            //if (name != "Jesse")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}


            /////
            //IF, ELSE IF branching
            /////
            //string name = "Erik";
            //if (name == "Jesse")
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is Brett");
            //}
            //else if (name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam");
            //}
            //else
            //    Console.WriteLine("I don't know you");


            /////
            //IF ELSE branching with LESSER THAN EQUAL TO operators
            /////
            //int age = 20;
            //if (age <= 20)
            //{
            //    Console.WriteLine("You may not purchase that bottle of wine.");
            //}
            //else
            //{
            //    Console.WriteLine("There you go.");
            //}


            /////
            //IF branching with EQUAL, AND operators
            /////
            //if (1 == 1 && 5 == 5)
            //{
            //    Console.WriteLine("All is right with the world.");
            //}


            /////
            //IF, ELSE branching OR operator
            /////
            //if (true || false)
            //{
            //    Console.WriteLine("At least one value is true.");
            //}

            //if (false || false)
            //{
            //    Console.WriteLine("At least one value is true.");
            //}
            //else
            //{
            //    Console.WriteLine("No value is true.");
            //}

            //if (false || false || false || false || true)
            //{
            //    Console.WriteLine("Something is true.");
            //}


            /////
            //IF branching EQUALS and OR operators
            /////
            //string role = "admin";
            //if (role == "admin" || role == "administrator")
            //{
            //    Console.WriteLine("You may have access to the entire software system.");
            //}

            //if (true && ((true || false) || true) && ((false && false) || (true && true)))
            //{
            //    Console.WriteLine("Wow that was confusing.");
            //}


            /////
            //very long IF, ELSE IF branching
            /////
            //int currentTemperature = 80;
            //int roomTemperature = 72;
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not room temperature");
            //}


            /////
            //shorter IF, ELSE IF branching known as a ternary operator
            /////
            //int currentTemperature = 80;
            //int roomTemperature = 72;
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";
            //Console.WriteLine(comparisonResult);

            /////
            //Interactive program using IF, ELSE branching
            /////
            //int roomTemperature = 72;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is cooler than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Oops! Something went wrong.");
            //}


            /////
            //Interactive program using ternary operator
            /////
            Console.WriteLine("What is your favorite number between 1-5?");
            int favnum = Convert.ToInt32(Console.ReadLine());

            string result = favnum == 2 ? "You have an awesome favorite number" : "You don't actually have an awesome favorite number";
            Console.WriteLine(result);

            Console.ReadLine();
        }
        
    }
}
