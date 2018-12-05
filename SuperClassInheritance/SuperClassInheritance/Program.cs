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
            ////From drill 124
            //Employee dude = new Employee();
            //dude.FirstName = "Sample";
            //dude.LastName = "Student";
            //dude.SayName();
            //Console.ReadLine();

            ////From drill 126
            //IQuittable stuff = new Employee();
            //stuff.Quit();

            //From drill 129
            Employee teamMember = new Employee() { FirstName = "Dani", LastName = "Amsalem", Id = 10 };
            Employee teamMember2 = new Employee() { FirstName = "Tom", LastName = "Brady", Id = 11 };


            //if (teamMember.Id == teamMember2.Id)
            //{
            //    teamMember.SayName();
            //    teamMember2.SayName();
            //}
            //else
            //{
            //    Console.WriteLine("They aren't the same!");
            //}

           bool elmo = (teamMember.Id == teamMember2.Id);
           
           Console.WriteLine(elmo);
           
            teamMember.SayName();
            teamMember2.SayName();

            Console.ReadLine();
        }
    }
}
