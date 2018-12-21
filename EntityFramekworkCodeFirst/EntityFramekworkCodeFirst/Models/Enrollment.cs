using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramekworkCodeFirst.Models
{
    //This object will be a create the database with all its columns
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //Grade is an enum, the question mark indicates it can be nullable
        public Grade? Grade { get; set; }

        //This is a navigation property which holds other entities
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}