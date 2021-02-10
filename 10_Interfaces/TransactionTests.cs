using _10_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _10_Interfaces
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid {payment.Value} towards your debt");
        }

        // Setup for tests - this runs before any test is run
        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.01m; // insert meme reference here
        }

        [TestMethod]
        public void PayDebtTest()
        {
            var dollar = new Dollar();
            PayDebt(dollar);
            PayDebt(new Dime());
            PayDebt(new ElectronicPayment(300.50m));

            decimal expectedDebt = 9000.01m - 301.6m;

            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectionTest()
        {
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(123.45m);

            // Dependency Injection - the Transaction class depends on some kind of currency (ICurrency), which we have to "inject" as an argument in the constructor
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());
        }
    }
}
