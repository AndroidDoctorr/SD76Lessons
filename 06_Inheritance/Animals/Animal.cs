using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.Animals
{
    public enum DietType { Herbivore, Carnivore, Omnivore }
    // abstract means we're only using this class for inheritance
    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("This is the Animal constructor");
        }

        public int NumberOfLegs { get; set; }
        public DietType WhatItEats { get; set; }
        public bool IsHungry { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves!");
        }
    }
}
