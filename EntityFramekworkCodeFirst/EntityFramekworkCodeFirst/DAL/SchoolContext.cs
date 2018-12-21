using EntityFramekworkCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EntityFramekworkCodeFirst.DAL
{
    //This object coordinates the Entity Framework functionality
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
            ///The connection string will be passed in later through the web.config file
            ///If it wasn't specified, the default name is the class name or "SchoolContext"
        }

        ///DbSet is an Entity Set. 
        ///And an entity is an entry or a row in a table.
        ///So a DbSet is a table.
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        
    }
}