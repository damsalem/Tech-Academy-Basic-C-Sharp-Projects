using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifier
{
    //"public" = access modifier
    //"class" = showing that this is a class
    //"SampleClass" = name of the class
    public class SampleClass
    {
        //"testClass" = name of the class
        public int testClass(int x)
        {

            int answer = x + 5;
            return answer;
        }

        //The following is a "constructor".
        //Constructors are automatically invoked whenever an instance of the class is created
        //Classes can only have 1 constructor
        //Constructors need to have the same name as the class
        //Constructors don't have any return type, not even void.
        public SampleClass()
        {
        }
    }
}
