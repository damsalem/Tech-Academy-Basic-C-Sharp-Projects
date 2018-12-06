using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee("Dani", "Amsalem", 01));
            employeeList.Add(new Employee("Tom", "Sawyer", 02));
            employeeList.Add(new Employee("Billy", "Bob", 03));
            employeeList.Add(new Employee("Ricky", "Bobby", 04));
            employeeList.Add(new Employee("Joe", "Smith", 05));
            employeeList.Add(new Employee("Cleetus", "Mariner", 06));
            employeeList.Add(new Employee("Preshant", "Lululemon", 07));
            employeeList.Add(new Employee("Terry", "Arnold", 08));
            employeeList.Add(new Employee("Margaux", "Delomez", 09));
            employeeList.Add(new Employee("Joe", "Wright", 10));

            List<Employee> Joes1 = new List<Employee>();

            foreach (Employee x in employeeList)
            {
                if (x.fName == "Joe")
                {
                    Joes1.Add(x);
                }
            }

            List<Employee> Joes2 = new List<Employee>();

            employeeList.ForEach(x => { if (x.fName.Contains("Joe")) Joes2.Add(x); });

            List<Employee> employee5 = new List<Employee>();
            employeeList.ForEach(x => { if (x.ID > 5) employee5.Add(x); });

            //Writing the Joes1 list
            foreach (Employee joe in Joes1)
            {
                Console.WriteLine(joe.fName);
            }

            //Writing the Joes2 list
            foreach (Employee joe in Joes2)
            {
                Console.WriteLine(joe.fName);
            }

            //Writing the employee5 list
            foreach (Employee name in employee5)
            {
                Console.WriteLine(name.ID);
            }
            Console.ReadLine();
        }
    }
}
