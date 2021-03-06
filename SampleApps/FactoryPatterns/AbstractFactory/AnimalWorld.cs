﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.AbstractFactory
{
    /// <summary>
    /// Represents the client class
    /// </summary>
   public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();

        }

        public void RunFoodChain()
        {
           _carnivore.Eat(_herbivore);
        }
    }
}
