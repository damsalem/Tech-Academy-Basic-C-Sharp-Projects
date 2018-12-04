using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifier
{
    //AnotherClass is inheriting the properties of the slightlyAbstract class
    public class AnotherClass : SlightlyAbstract
    {
        //Implementing the abstract method "play" from the SlightlyAbstract class
        //This does require the "override" keyword
        public override void Play()
        {
            //This creates an error when compiling to let you know it was implemented yet
            throw new NotImplementedException();
        }
    }
}
