using _10_Interfaces.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IConsole
{
    public class ProgramUI
    {
        private readonly IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            List<IFruit> fruitSalad = new List<IFruit>();
            Banana banana = new Banana();
            Orange orange = new Orange(false);
            Grape grape = new Grape();
            Grape otherGrape = new Grape();

            fruitSalad.Add(banana);
            fruitSalad.Add(orange);
            fruitSalad.Add(grape);
            fruitSalad.Add(otherGrape);

            foreach (IFruit fruit in fruitSalad)
            {
                _console.WriteLine($"This is a {fruit.Name}");
                _console.WriteLine(fruit.Peel());
            }

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
