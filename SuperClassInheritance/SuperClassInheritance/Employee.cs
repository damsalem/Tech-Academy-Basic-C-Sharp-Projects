using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassInheritance
{
    public class Employee<T> : Person, IQuittable
    {
        //Exercise 131 #3 Method one: Generic type parameter
        public List<T> test;
        public Employee()
        {
            List<T> test = new List<T>();
        }

        public int Id { get; set; }

        public new void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine("I quit");
        }

        //Exercise 129
        //public static bool operator ==(Employee employee, Employee employee2)
        //{
        //    bool sameEmployee = employee.Id == employee2.Id;
        //    return sameEmployee;
        //}

        //public static bool operator !=(Employee employee, Employee employee2)
        //{
        //    bool notEmployee = employee.Id != employee2.Id;
        //    return notEmployee;
        //}

        //Exercise 131 #3 Method Two: Generic type parameter
        public List<T> things { get; set; }
    }
}
