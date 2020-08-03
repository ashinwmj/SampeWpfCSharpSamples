using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.FactoryMethod
{
    public class TatkalTicket:ITicket
    {
        public decimal GetPrice()
        {
            return 440;
        }
    }
}
