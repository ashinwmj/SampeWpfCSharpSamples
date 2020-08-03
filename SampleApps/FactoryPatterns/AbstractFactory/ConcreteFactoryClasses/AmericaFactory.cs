using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatterns.AbstractFactory.ConcreteProductClasses;

namespace FactoryPatterns.AbstractFactory
{
   public class AmericaFactory:ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison(); 
        }

        public override Carnivore CreateCarnivore()
        {
            return  new Wolf();
        }
    }

   public class Wolf : Carnivore
   {
       public override void Eat(Herbivore herbivore)
       {
           throw new NotImplementedException();
       }
   }
}
