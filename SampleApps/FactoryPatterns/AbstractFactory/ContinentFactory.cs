using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.AbstractFactory
{
    /// <summary>
    /// Represents the abstract Factory Class
    /// </summary>
   public abstract  class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();

    }
}
