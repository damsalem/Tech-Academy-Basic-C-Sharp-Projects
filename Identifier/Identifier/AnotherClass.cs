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

    //Generic classes don't have specific properties and are primarily used in lists.
    public class Family<T>
    {
        //This is a generic list. When creating the Family object, we set the data type for List
        public List<T> fName { get; set; }
    }

    //Structs = structure and are basically classes
    //Except structs are value type not reference type, so they're faster
    //Structs work on number types and bools and more
    //But they don't work on strings, arrays, and classes.
    public struct foReal
    {

    }
}
