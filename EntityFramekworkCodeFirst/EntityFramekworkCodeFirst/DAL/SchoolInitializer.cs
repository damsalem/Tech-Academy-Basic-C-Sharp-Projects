using EntityFramekworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramekworkCodeFirst.DAL
{
    ///This object initializes the dB
    ///And uses SchoolContext object as a parameter to add new entities in the method
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2018-09-01")}
            };
            students.ForEach(s => context.Students.Add(s));
            ///It isn't necessary to use the save method after each group,
            ///but it can help locate the source of issues
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID=1000,Title="Computer & Technology Basics"},
            new Course{CourseID=2000,Title="Overview of Software Development"},
            new Course{CourseID=3000,Title="Version Control"},
            new Course{CourseID=4000,Title="HTML & CSS"},
            new Course{CourseID=5000,Title="JavaScript"},
            new Course{CourseID=6000,Title="Database & SQL"},
            new Course{CourseID=7000,Title="C# & .NET Framework"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1000,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=2000,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=3000,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1000,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=2000,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=3000,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=7000},
            new Enrollment{StudentID=4,CourseID=6000,},
            new Enrollment{StudentID=4,CourseID=7000,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=7000,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=7000},
            new Enrollment{StudentID=7,CourseID=7000,Grade=Grade.A},
            new Enrollment{StudentID=8,CourseID=1000,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}