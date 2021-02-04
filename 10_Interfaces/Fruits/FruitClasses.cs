using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        // Arrow notation - super shorthand for returning a value like in a method that you can use in a few specific places
        public string Name => "Banana";
        // public string Name {get;} = "Banana"
        public bool IsPeeled { get; private set; } = false;

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana";
        }
    }

    public class Orange : IFruit
    {
        public bool IsPeeled { get; private set; }
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        // public string Name => "Orange";
        // public string Name {get;} = "Orange";

        // ^ These aren't just valid when using interfaces, you can do this in any class
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            if (IsPeeled)
            {
                // throw new Exception("It's already been peeled!");
                return "This orange has already been peeled!";
            }

            IsPeeled = true;
            return $"You peel the {GetType().Name}";
        }

        public string Squeeze()
        {
            return "You get orange juice!";
        }
    }

    public class Mandarin : Orange
    {
        // I don't have to define all those methods and properties again, it uses the Mandarin definitions.
        // Here, I can add proprties that Mandarin will have but not Orange
        public Mandarin(bool isPeeled) : base(isPeeled) { }
    }

    public class Grape : IFruit
    {
        // The getter always returns "Grape"
        public string Name => "Grape";
        // these two property definitions work the same way
        public bool IsPeeled { get; } = false;

        public string Peel()
        {
            throw new Exception("what are you, a toddler?");
            // return "who the heck peels grapes?";
            // apparently toddlers making rosé
        }
    }



    // CHALLENGE:

    // Create your own member of the IFruit interface, with its own unique implementation of Peel() and one each additional property and method.
    // Add it to the fruitBasket List in the Test Method


}
