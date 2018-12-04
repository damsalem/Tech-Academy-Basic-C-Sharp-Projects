using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassInheritance
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public new void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}
