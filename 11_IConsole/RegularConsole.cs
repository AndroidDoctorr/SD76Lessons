using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IConsole
{
    public class RegularConsole : IConsole
    {
        public void Clear() { Console.Clear(); }

        public ConsoleKeyInfo ReadKey() { return Console.ReadKey(); }

        public string ReadLine() { return Console.ReadLine(); }

        public void Write(string s) { Console.Write(s); }

        public void WriteLine(string s)
        {
            // WriteLine adds "\n" at the end
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
