using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InterviewTest.Models;

namespace InterviewTest.Models
{
    public class QuoteRepo
    {

        InterviewTestContext ctx = new InterviewTestContext();


        public Quote getQuoteById(int id)
        {

            return ctx.Quote.Find(id);
        }

        public int getQuoteCounts()
        {
            return ctx.Quote.Count();
        }
    }
}