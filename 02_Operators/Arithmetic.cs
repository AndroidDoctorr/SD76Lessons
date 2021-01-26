using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(9 + 13);
            Console.WriteLine(42 - 100);
            Console.WriteLine(99 * 99);
            Console.WriteLine(10.0 / 3.0);
            Console.WriteLine(10 % 3);
        }
    }
}
