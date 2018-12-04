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
        //"int" is a return type
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

        //This creates a method with a string within it
        //That's cleaner than declaring the list first then inputting the name
        public void Stuff(List<string> moreStuff)
        {
        }
    }

    //Abstract classes have both abstract methods and virtual methods.
    public abstract class SlightlyAbstract
    {
        //The following are properties
        public List<string> Guys { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        //This was inherited/polymorphed from the other class
        public AnotherClass stuff { get; set; }

        //Abstract methods cannot be implemented but instead 
        //MUST have some implementation though inheriting or polymorphism
        public abstract void Play();

        //Virtual methods are inherited and can be implemented, with the possibility of being overridden.
        public virtual void ListGuys()
        {
            foreach (string guy in Guys)
            {
                Console.WriteLine(guy);
            }
        }
    }
}
