using _06_Inheritance.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance.PeopleTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CustomersAndUsers()
        {
            User user = new User("fake@email.com", "FakeUser");
            Customer customer = new Customer("notReal@fakeEmail.biz");

            // user.SetFirstName("Ross");
            // user.SetLastName("Denman");

            customer.SetFirstName("Zuri");
            customer.SetLastName("Rojas");

            Console.WriteLine("User:");
            Console.WriteLine(user.ID);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.Name);
            Console.WriteLine("Customer:");
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.Name);
        }
    }
}
