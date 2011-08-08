using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterviewTest.Models;

namespace InterviewTest.Tests
{
    class FakeQuoteRepository
    {


        private static IQueryable<Quote> quotes = new List<Quote> { 
            new Quote { QuoteText = "You can't fake Quality any more than you can fake a good meal", QuoteAuthor ="William S. Burroughs" },
            new Quote { QuoteText = "Never regret. If it's good, it's wonderful. If it's bad, it's experience.", QuoteAuthor ="Victoria Holt" }, 
            new Quote { QuoteText = "True originality consists not in a new manner but in a new vision.", QuoteAuthor ="Edith Wharton" }, 
            new Quote { QuoteText = "If you greatly desire something, have the guts to stake everything on obtaining it.", QuoteAuthor ="Brendan Francis" }, 
            new Quote { QuoteText = "A mind troubled by doubt cannot focus on the course to victory.", QuoteAuthor ="Arthur Golden" }, 
            new Quote { QuoteText = "Real integrity is doing the right thing, knowing that nobody's going to know whether you did it or not.", QuoteAuthor ="Oprah Winfrey" } 
            
            
        }.AsQueryable();
        
        public IQueryable<Quote> Quotes
        {
            get { return quotes; }
        } 


        



        
    }
}
