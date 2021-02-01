using _06_Inheritance.Animals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance.AnimalTests
{
    [TestClass]
    public class BirdTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Animal animal = new Animal();
            // animal.NumberOfLegs = 4;
            // animal.Move();
            Bird bird = new Bird();
            bird.WingSpan = 4.5;
            bird.Move();
            Eagle eagle = new Eagle();
            eagle.WingSpan = 7.8;
            eagle.Move();
        }
    }
}
