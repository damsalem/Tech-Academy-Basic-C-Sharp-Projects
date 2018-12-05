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
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit");
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            bool sameEmployee = employee.Id == employee2.Id;
            return sameEmployee;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            bool notEmployee = employee.Id != employee2.Id;
            return notEmployee;
        }
    }
}
