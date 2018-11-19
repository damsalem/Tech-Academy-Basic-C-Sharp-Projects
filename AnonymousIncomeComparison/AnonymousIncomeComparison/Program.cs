using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            //Person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int p1HourlyRate = 15;
            Console.WriteLine(p1HourlyRate);

            Console.WriteLine("Hours worked per week");
            int p1WeeklyHours = 40;
            Console.WriteLine(p1WeeklyHours);

            int p1Salary = p1HourlyRate * p1WeeklyHours;

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int p2HourlyRate = 25;
            Console.WriteLine(p2HourlyRate);

            Console.WriteLine("Hours worked per week");
            int p2WeeklyHours = 50;
            Console.WriteLine(p2WeeklyHours);

            int p2Salary = p2HourlyRate * p2WeeklyHours;

            Console.WriteLine("Annual salary of Person 1: " + p1Salary);
            Console.WriteLine("Annual salary of Person 2: " + p2Salary);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1Vsp2 = p1Salary > p2Salary;
            Console.WriteLine(p1Vsp2);
            Console.ReadLine();
        }
    }
}
