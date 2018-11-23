using System;
using System.Collections.Generic;

namespace IterationExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /////
            ///Iterating through an integer array
            /////
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            ////Arrays require a FOR to iterate through them
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing Test Score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            /////
            ///Iterating through a string array
            /////
            //string[] names = { "Dani", "Andy", "Samir", "Thai", "Ben", "Morgan" };

            ////Arrays require a FOR to iterate through them
            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();

            /////
            ///Iterating through a list integers
            /////
            //List<int> moreScores = new List<int>();
            //moreScores.Add(98);
            //moreScores.Add(98);
            //moreScores.Add(81);
            //moreScores.Add(72);
            //moreScores.Add(70);

            ////Lists require a FOREACH to iterate through them
            //foreach (int Score in moreScores)
            //{
            //    if (Score > 85)
            //    {
            //        Console.WriteLine("Passing Test Scores: " + Score);
            //    }
            //}
            //Console.ReadLine();


            /////
            ///Iterating through a list of strings -- NOTE This list in instantiated on the same line
            /////
            //List<string> moreNames = new List<string>() { "David", "Teri", "Juliet", "Megan" };

            ////Lists require a FOREACH to iterate through them
            //foreach (string name in moreNames)
            //{
            //    Console.WriteLine("The matching name is: " + name);
            //}
            //Console.ReadLine();


            /////
            ///Iterating through a list so it can be added to another list
            /////
            List<int> evenMoreTestScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in evenMoreTestScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
