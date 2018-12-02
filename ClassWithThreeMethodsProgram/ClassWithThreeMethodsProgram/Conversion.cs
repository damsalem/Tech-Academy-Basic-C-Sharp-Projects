using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithThreeMethodsProgram
{
    //This class has 3 methods by the same name. Use "overloading" to deal with that.
    public class Conversion
    {
        public int simpleMethod(int intAddition)
        {
            int answer = intAddition + 5;
            return answer;
        }

        public int simpleMethod(decimal decMultiplier)
        {
            decimal product = decMultiplier * 2;
            int answer = Convert.ToInt32(product);

            return answer;
        }

        public int simpleMethod(string stringInt)
        {
            if (stringInt.Contains("1") 
                || stringInt.Contains("2") 
                || stringInt.Contains("3")
                || stringInt.Contains("4")
                || stringInt.Contains("5")
                || stringInt.Contains("6")
                || stringInt.Contains("7")
                || stringInt.Contains("8")
                || stringInt.Contains("9")
                || stringInt.Contains("0"))
                {
                int stringToNumber = Convert.ToInt32(stringInt);

                int answer = stringToNumber * 5;
                return answer;
                }
            else
            {
                return 5;
            }


        }
    }
}
