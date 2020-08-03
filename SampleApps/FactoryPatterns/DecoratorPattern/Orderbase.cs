using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.DecoratorPattern
{
   public abstract class Orderbase
    {
       protected  IList<Product> Products=new List<Product>(){new Product(){Name = "PlayStation",Price = 28000},new Product(){Name = "Laptop",Price = 56000}};

        public abstract double CalculateTotalOrderPrice();

    }
}
