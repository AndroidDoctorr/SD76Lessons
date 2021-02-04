using _10_Interfaces.Fruits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _10_Interfaces
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void FruitTest()
        {
            // Can't do this because interface
            // IFruit iFruit = new IFruit();
            Banana banana = new Banana();
            Orange orange = new Orange(true);
            orange.Peel();
            banana.Peel();
            Grape grape = new Grape();
            Mandarin mandarin = new Mandarin(false);
            List<IFruit> fruitBasket = new List<IFruit>();

            fruitBasket.Add(banana);
            fruitBasket.Add(grape);
            fruitBasket.Add(orange);
            fruitBasket.Add(mandarin);

            foreach (IFruit fruit in fruitBasket)
            {
                if (fruit.Name != "Grape")
                {
                    Console.WriteLine(fruit.Peel());
                }
            }
        }
    }
}
