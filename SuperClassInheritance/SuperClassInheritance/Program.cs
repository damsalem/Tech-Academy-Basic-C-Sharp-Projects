using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee dude = new Employee();
            dude.FirstName = "Sample";
            dude.LastName = "Student";
            dude.sayname();
            Console.ReadLine();
        }
    }
}
