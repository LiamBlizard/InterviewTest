using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewTest.Models;
using System.Data.Entity;

namespace InterviewTest.Controllers
{
    public class QuoteController : Controller
    {
        //
        // GET: /Quote/

            
        public ActionResult Index()
        {
            using(var db = new QuoteDBEntities())
            {

                return View(db.Quotes.ToList());
            }
        }

      
        public ActionResult RandomQuote()
        {

            using(var db = new QuoteDBEntities())
            {
                Random rnd = new Random((int)DateTime.Now.Ticks);

                var model = db.Quotes.Find(rnd.Next(1, GetQuoteCounts()+1));
                
                
                return View(model);
             }
        }

        private int GetQuoteCounts()
        {
            using( var db = new QuoteDBEntities())
            {
                return db.Quotes.Count();
            }
        }

    }
}
