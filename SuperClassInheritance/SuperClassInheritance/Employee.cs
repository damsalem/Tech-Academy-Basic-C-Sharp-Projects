using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassInheritance
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public new void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
