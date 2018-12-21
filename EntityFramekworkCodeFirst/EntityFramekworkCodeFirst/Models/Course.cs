using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFramekworkCodeFirst.Models
{
    //This object will be a create the database with all its columns
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }

        //This is a navigation property which holds other entities
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}