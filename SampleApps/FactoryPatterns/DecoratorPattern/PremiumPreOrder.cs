using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.DecoratorPattern
{
    public class PremiumPreOrder:OrderDecorator
    {
        public PremiumPreOrder(Orderbase orderbase) : base(orderbase)
        {
        }

        public override double CalculateTotalOrderPrice()
        {
            Console.WriteLine("Calculating total price in the premium preorder  class");
            var prOrderPrice = base.CalculateTotalOrderPrice();
            Console.WriteLine("Calculating premium predorder price");
            return prOrderPrice * 0.9;
        }
    }
}
