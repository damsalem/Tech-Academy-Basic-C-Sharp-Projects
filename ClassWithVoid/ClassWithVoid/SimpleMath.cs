using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithVoid
{
    public class SimpleMath
    {
        public void returnMultiple(int mathNum, int displayNum)
        {
            int mathAddition = mathNum + 5;

            Console.WriteLine(mathAddition);
            Console.WriteLine(displayNum);
        }
    }
}
