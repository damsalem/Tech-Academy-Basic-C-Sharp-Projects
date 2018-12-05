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

            ////From drill 129
            //Employee teamMember = new Employee() { FirstName = "Dani", LastName = "Amsalem", Id = 10 };
            //Employee teamMember2 = new Employee() { FirstName = "Tom", LastName = "Brady", Id = 11 };

            ////if (teamMember.Id == teamMember2.Id)
            ////{
            ////    teamMember.SayName();
            ////    teamMember2.SayName();
            ////}
            ////else
            ////{
            ////    Constole.WriteLine("They aren't the same!");
            ////}
            //////The above is the same as what is below
            //bool elmo = (teamMember.Id == teamMember2.Id);

            //Console.WriteLine(elmo);

            //teamMember.SayName();
            //teamMember2.SayName();


            //Exercise 131 Beginning
            Employee<string> hello = new Employee<string>();

            //Exercise 131 #3 Method One
            hello.test = new List<string>() { "another test1", "another test2" };
            hello.test.ForEach(i => Console.WriteLine("{0}", i));

            //Exercise 131 #3 Method TWo
            hello.things = new List<string>() { "test 1", "test 2" };
            hello.things.ForEach(i => Console.WriteLine("{0}", i));

            Employee<int> hi = new Employee<int>();
            hi.things = new List<int>() { 1, 2, 3, 4 };
            hi.things.ForEach(i => Console.WriteLine("{0}", i));

            Console.ReadLine();
        }
    }
}
