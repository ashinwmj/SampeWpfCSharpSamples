using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.FactoryMethod
{
    public class OrdinaryTicket:ITicket
    {
        public decimal GetPrice()
        {
            return 330;
        }
    }
}
