using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.AbstractFactory
{
   public abstract class Carnivore
   {
       public abstract void Eat(Herbivore herbivore);

   }
}
