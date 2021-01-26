using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void TestMethod1()
        {
            int day = 1;

            switch (day)
            {
                case 0:
                    Console.WriteLine("Happy Monday /s :(");
                    break;
                case 1:
                    Console.WriteLine("It is Tuesday.");
                    break;
                case 2:
                    Console.WriteLine("Happy Hump Day!");
                    break;
                default:
                    Console.WriteLine("Happy whatever day");
                    break;
            }
        }
    }
}
