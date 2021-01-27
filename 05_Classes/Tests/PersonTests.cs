using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            Person person = new Person();
            person.FirstName = "Andrew";
            person.LastName = "Torr";
            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.WriteLine(person.FullName);

            Person otherPerson = new Person(
                "Ashley",
                "Lawrence",
                new DateTime(1989, 4, 26),
                new Vehicle()
            );

            Console.WriteLine(otherPerson.FullName);
            Console.WriteLine("make: " + otherPerson.Vehicle.Make);
            // otherPerson.FirstName = "Ash";
        }
    }
}
