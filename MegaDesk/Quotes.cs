using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class Quotes
    {

        public Stack<Desk> quotes = new Stack<Desk>();

        public void addQuote(Desk desk)
        {
            quotes.Push(desk);
        }
       
        public Stack<Desk> getQuotes()
        {
            return quotes;
        }

    }
}
