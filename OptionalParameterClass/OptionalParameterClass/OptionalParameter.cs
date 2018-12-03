using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterClass
{
    public class OptionalParameter
    {
        //Create an optional argument/parameter by declaring its default value
        public int singleOrDoubleParam(int requiredInt, int optionalInt = 0)
        {
            int answer = (requiredInt + optionalInt) * 2;
            return answer;
        }
    }
}
