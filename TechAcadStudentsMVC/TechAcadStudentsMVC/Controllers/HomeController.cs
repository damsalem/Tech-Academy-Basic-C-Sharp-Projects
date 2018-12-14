using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        ///ActionResult is a class defined in the Mvc library.
        ///It can be often considered "rendered HTML"
        
        ///The Index method is a cshtml file in the View folder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contage Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id=0)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                FirstName = "Dani",
                LastName = "Amsalem"
            };
            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructorList = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ross"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Brett",
                    LastName = "Money"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "AndEve"
                }
            };

            return View(instructorList);
        }
    }
}