using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatterns.AbstractFactory.ConcreteProductClasses;

namespace FactoryPatterns.AbstractFactory
{
    public class AfricaFactory:ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
           return new Elephant();
        }

        public override Carnivore CreateCarnivore()
        {
            return  new Lion();
        }
    }
}
