using System;
namespace TTA_Daily_Report
{
    class Program
    {
        static void Main()
        {
            //Intro
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Press [Enter] to start");
            Console.ReadLine();

            //First question
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            //Second question
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            byte pgNum = Convert.ToByte(pageNumber);

            //Third question
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string helpNeeded = Console.ReadLine();
            bool help = Convert.ToBoolean(helpNeeded);

            //Fourth question
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();

            //Fifth question
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            byte hrsStudied = Convert.ToByte(hoursStudied);

            //Sixth question
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("Press [Enter] to display your results.");
            Console.ReadLine();

            //Display results
            Console.WriteLine("You are on this course: " + currentCourse);
            Console.WriteLine("You are on this page: " + pgNum);
            Console.WriteLine("You need help: " + help);
            Console.WriteLine("Your feedback is: " + studentFeedback);
            Console.WriteLine("You studied " + hrsStudied + " hour(s) today.");
            Console.ReadLine();
        }
    }
}
