using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalInterviewQs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] oddNums = new int[5];
            foreach (int num in nums)
            {
                if (isOdd(num))
                {
                    oddNums.
                }
            }
            int sum = oddNums.Sum();
            Console.WriteLine(sum);
        }
        public static bool isOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
