using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greeter greeter = new Greeter();
                            // argument
            greeter.SayHello("Andrew");

            greeter.SayRandomGreeting("Ross");
        }
    }
}
