using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewQs
{
    class Program
    {
        ///
        ///Given an array of integers, write a method to total the odd numbers.
        ///
        static void Main(string[] args)
        {
            bool IsOdd(int value)
            {
                return value % 2 != 0;
            }

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] oddNums = new int[5];
            int i = 0;
            foreach (int num in nums)
            {
                if (IsOdd(num))
                {
                    oddNums.SetValue(num, i);
                    i++;
                }
            }
            Console.WriteLine("The oddNums array = ");
            foreach (int num in oddNums)
            { Console.Write(num + ", "); }
            Console.WriteLine();
            int sum = oddNums.Sum();
            Console.WriteLine("The sum of the oddNums array = " + sum);
            Console.ReadLine();


            ///Given an array of integers, write a method to sum the elements in the array,
            ///knowing that some of the elements may be very large integers
            ///
            int[] bigNums = new int[] { 100, 1000, 10000, 100000, 10000000, 900000000, 900000000 };
            //I noticed here that though MVS gives me an error if I make any of those ints larger
            //I don't get an error when summing them up
            int bigSum = bigNums.Sum();
            Console.WriteLine(bigSum);
            Console.ReadLine();


            ///Given a string, reverse it.
            ///
            string ReverseString(string s)
            {
                char[] array = s.ToCharArray();
                Array.Reverse(array);
                return new string(array);
            }

            string aName = "nevar adaven";
            Console.WriteLine("The original string is: " + aName);
            Console.WriteLine("The reversed string is: " + ReverseString(aName));
            Console.WriteLine();
            Console.ReadLine();


            ///Given a string, remove any repeated letters.
            ///
            string RemoveDupLetters(string s)
            {
                return new string(s.Distinct().ToArray());
            }
            string longString = "How much would could a woodchuck chuck, if a woodchuck, could chuck, would?";
            Console.WriteLine(longString);
            Console.WriteLine(RemoveDupLetters(longString));
            Console.ReadLine();

            ///Fizzbuzz
            ///When a number is multiple of three, print “Fizz” instead of a number on the console.
            ///If multiple of five then print “Buzz” on the console.
            ///For numbers which are multiple of three as well five, print “FizzBuzz” on the console.
            ///
            for (i = 0; i < 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
                else Console.WriteLine(i);
            }
            Console.ReadLine();
        }

    }
}
