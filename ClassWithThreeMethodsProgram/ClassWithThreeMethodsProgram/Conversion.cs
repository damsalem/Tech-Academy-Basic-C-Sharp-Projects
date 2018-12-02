using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithThreeMethodsProgram
{
    public class Conversion
    {
        public int simpleMethod(int x)
        {
            int answer = x + 5;
            return answer;
        }

        public int simpleMethod(decimal x)
        {
            decimal product = x * 2;
            int answer = Convert.ToInt32(product);

            return answer;
        }

        public int simpleMethod(string x)
        {
            if (x.Contains("1") 
                || x.Contains("2") 
                || x.Contains("3")
                || x.Contains("4")
                || x.Contains("5")
                || x.Contains("6")
                || x.Contains("7")
                || x.Contains("8")
                || x.Contains("9")
                || x.Contains("0"))
                {
                int stringToNumber = Convert.ToInt32(x);

                int answer = stringToNumber * 5;
                return answer;
                }
            else
            {
                int answer = Int32.Parse(x);
                return answer;
            }


        }
    }
}
