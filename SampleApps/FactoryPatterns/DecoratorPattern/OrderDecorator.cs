using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.DecoratorPattern
{
   public class OrderDecorator:Orderbase
   {
       private Orderbase _orderbase;
        public OrderDecorator(Orderbase orderbase)
        {
            _orderbase = orderbase;
        }
        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating total price in the decorator class");
           return _orderbase.CalculateTotalOrderPrice();
        }
    }
}
