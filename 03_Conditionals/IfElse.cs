using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatement()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat something!");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 12)
            {
                Console.WriteLine("Are you even trying??");
            }
        }

        [TestMethod]
        public void IfElseStatements()
        {
            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun at the movies!");
            } else
            {
                Console.WriteLine("You must stay home and finish your chores!");
            }


            int age = 60;
            if (age >= 54)
            {
                Console.WriteLine("You are a super duper adult");
            }
            else if (age >= 36)
            {
                Console.WriteLine("You are a super adult");
            } 
            else if (age >= 18)
            {
                Console.WriteLine("You are an adult");
            } else
            {
                Console.WriteLine("You are a child. Go away.");
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 35;

            Console.WriteLine("Welcome to the library, you may visit the " 
                + (age >= 18 ? "whole library" : "children's section only"));

            bool hasKey = true;
            int score = hasKey ? 200 : 50;
        }
    }
}
