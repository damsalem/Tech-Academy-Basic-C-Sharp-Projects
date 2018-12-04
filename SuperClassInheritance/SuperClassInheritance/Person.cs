using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassInheritance
{
    public class Person
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void sayname()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }

}
