using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithMethod
{
    public class SimpleMath
    {
        //public int justDoIt(int userNum)
        //{
        //    int answer = userNum + 10;
        //    return answer;
        //}

        public void simpleMethod(int userNum1)
        {
            int difference = userNum1 / 2;
            Console.WriteLine(difference);
        }

        public void simpleMethod(int userNum2, out int answer1, out int answer2)
        {
            answer1 = userNum2 + 10;
            answer2 = userNum2 * 2;
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
        }
    }
}
