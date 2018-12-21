using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramekworkCodeFirst.Models
{
    //This object will be a create the database with all its columns
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        ///This is a navigation property which holds other entities
        ///Because it is an ICollection, it's basically a list
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}