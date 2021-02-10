using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Sef";
            string lastName = "Mclaughlin";

            string concatenated = firstName + " " + lastName;

            string interpolated = $"{firstName} {lastName}";

            string composited = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(concatenated);
            Console.WriteLine(interpolated);
            Console.WriteLine(composited);
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello world!";

            string[] stringArray = { "Hello", "World", "Why", "is", "it", "always", stringExample, "?" };

            string thirdItem = stringArray[2];

            Console.WriteLine(thirdItem);

            stringArray[0] = "Hello there";
            Console.WriteLine(stringArray[0]);


            // Lists

            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("some \"silly\" nonsense");
            listOfInts.Add(12345);
            int length = listOfStrings.Count;

            Console.WriteLine(listOfStrings[0]);
            Console.WriteLine(listOfInts[0]);

            // Queues

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            Console.WriteLine(firstInFirstOut.Dequeue());

            // Dictionaries

            Dictionary<int, string> keysAndValues = new Dictionary<int, string>();

            keysAndValues.Add(5, "something");
            keysAndValues.Add(6, "something else");
            keysAndValues[5] = "something totally different";
            Console.WriteLine("DICTIONARY VALUE: " + keysAndValues[5]);

            Dictionary<string, decimal> importantNumbers = new Dictionary<string, decimal>();

            importantNumbers.Add("pi", 3.141592653589793238462643383279m);
            importantNumbers.Add("phi", 1.681033m);
            Console.WriteLine(importantNumbers["pi"]);

            Dictionary<string, Dictionary<string, string>> dictionaryception = new Dictionary<string, Dictionary<string, string>>();


            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            sortedKeyAndValue.Add(13, "blah");
            HashSet<int> uniqueList = new HashSet<int>();
            uniqueList.Add(1);
            uniqueList.Add(3);
            uniqueList.Add(5);
            HashSet<int> otherHashSet = new HashSet<int>();
            otherHashSet.Add(3);
            Console.WriteLine(uniqueList.Overlaps(otherHashSet));

            Stack<string> lastInFirstOut = new Stack<string>();

        }

        [TestMethod]
        public void Classse()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0, 10);

            Console.WriteLine(randomNumber);

            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
            Console.WriteLine(rng.Next(1,10));
        }
    }
}
