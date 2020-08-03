using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPatterns.DecoratorPattern
{
   public class PreOrder:Orderbase
    {
      
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine($"Calculating price of Pre- orders ");
            return Products.Sum(x => x.Price);
        }
    }
    
}
