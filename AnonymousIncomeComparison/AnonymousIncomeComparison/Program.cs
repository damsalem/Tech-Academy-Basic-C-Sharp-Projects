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
            string p1Rate = Console.ReadLine();
            int p1HourlyRate = Convert.ToInt32(p1Rate);

            Console.WriteLine("Hours worked per week");
            string p1Hours = Console.ReadLine();
            int p1WeeklyHours = Convert.ToInt32(p1Hours);

            int p1Salary = p1HourlyRate * p1WeeklyHours;

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            string p2Rate = Console.ReadLine();
            int p2HourlyRate = Convert.ToInt32(p2Rate);

            Console.WriteLine("Hours worked per week");
            string p2Hours = Console.ReadLine();
            int p2WeeklyHours = Convert.ToInt32(p2Hours);

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
