using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatterns.DecoratorPattern
{
   public class RegularOrder:Orderbase
    {
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating price of regular products ");
            return Products.Sum(x => x.Price);
        }
    }
}
