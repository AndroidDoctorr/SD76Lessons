using _10_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void PennyTest()
        {
            ICurrency penny = new Penny();

            Assert.AreEqual(0.01m, penny.Value);
            Assert.AreEqual("Penny", penny.Name);
        }

        [DataTestMethod]
        [DataRow(105.73)]
        [DataRow(2.67)]
        [DataRow(123.45)]
        public void EPaymentTests(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
