using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance.Animals
{
    public class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("This is the Bird constructor");
        }
        public double WingSpan { get; set; }

        public override void Move()
        {
            Console.WriteLine("This bird is about to move!");
            // base.Move();
            Console.WriteLine($"This {GetType().Name} flies!");
        }
    }

    public class Eagle : Bird
    {
        public Eagle()
        {
            Type type = GetType();
            string Name = type.Name;
            Console.WriteLine("This is the Eagle constructor");
        }
    }
}
