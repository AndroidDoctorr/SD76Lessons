using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Greeter
    {
        // Method
                            // parameter
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        Random _random = new Random();
        public void SayRandomGreeting(string name)
        {
            Console.WriteLine($"{GetRandomGreeting()}, {name}");
        }

        private string GetRandomGreeting()
        {
            string[] greetings = new string[] { "Hi", "Yo", "whats up", "How are you", "Здравствуйте", "Guten Tag", "Hola" };
            int randomNumber = _random.Next(0, greetings.Length);
            string randomGreeting = greetings.ElementAt(randomNumber);
            // string randomGreeting = greetings[randomNumber];
            return randomGreeting;
        }
    }
}
