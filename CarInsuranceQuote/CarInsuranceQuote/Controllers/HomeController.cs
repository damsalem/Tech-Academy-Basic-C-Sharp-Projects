using CarInsuranceQuote.ViewModel;
using CarInsuranceQuote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(DateTime DateOfBirth, int CarYear, string CarMake, string CarModel, 
                                    int SpeedingTickets, string FirstName, string LastName, string Email, 
                                    bool DUI = false, bool FullCoverage = false)
        {
            decimal Quote = 50.0m;

            int dob = DateOfBirth.Year;
            int thisYear = DateTime.Now.Year;
            int birthYear = thisYear - dob;
            int age = thisYear = birthYear;
            
            if (age < 18) Quote += 100m;
            else if (age > 18 && age < 25) Quote += 25m;
            else if (age > 100) Quote += 25m;

            if (CarYear < 2000) Quote += 25m;
            else if (CarYear > 2015) Quote += 25m;

            if (CarMake == "Porsche") Quote += 25m;

            if (CarMake == "Porsche" && CarModel == "911 Carrera") Quote += 25m;
            
            for (int i = 0; i < SpeedingTickets; i++) Quote += 10m;

            if (DUI) Quote += (Quote * 0.25m);

            if (FullCoverage) Quote += (Quote * 0.50m);

            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var insuranceDb = new QuoteData();
                insuranceDb.FirstName = FirstName;
                insuranceDb.LastName = LastName;
                insuranceDb.EmailAddress = Email;
                insuranceDb.DateOfBirth = DateOfBirth;
                insuranceDb.CarYear = CarYear;
                insuranceDb.CarMake = CarMake;
                insuranceDb.CarModel = CarModel;
                insuranceDb.SpeedingTickets = SpeedingTickets;
                insuranceDb.DUI = DUI;
                insuranceDb.FullCoverage = FullCoverage;
                insuranceDb.Quote = Quote;

                db.QuoteDatas.Add(insuranceDb);
                db.SaveChanges();
            }


            QuoteVm quoteVm = new QuoteVm();
            quoteVm.FirstName = FirstName;
            quoteVm.LastName = LastName;
            quoteVm.Email = Email;
            quoteVm.Quote = Math.Round(Quote, 2);

            return View(quoteVm);
        }

        public ActionResult Quote()
        {
            return View();
        }

        public ActionResult Admin(QuoteData dB)
        {
            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var quotes = new List<AdminVm>();

                foreach (var quote in db.QuoteDatas)
                {
                    AdminVm adminVm = new AdminVm();
                    adminVm.FirstName = quote.FirstName;
                    adminVm.LastName = quote.LastName;
                    adminVm.Email = quote.EmailAddress;
                    adminVm.Quote = Math.Round(quote.Quote, 2);
                    quotes.Add(adminVm);
                }
            return View(quotes);
            }
        }
    }
}