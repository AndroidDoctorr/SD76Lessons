using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_IConsole
{
    class Program
    {
        // e.g. git remote -v  => args is [ "remote", "-v" ]
        // args are options you can run your program with
        // >> Game.exe useSave 1234
        static void Main(string[] args)
        {
            // if (args.Contains("useSave")) { ... }
            IConsole regularConsole = new RegularConsole();
            var funConsole = new FunConsole("Bob");
            ProgramUI ui = new ProgramUI(funConsole);
            ui.Run();

            // With DI, I can use interchangeable parts in my code
            // e.g. different UIs, like mobile vs web
            // or different databases (IDatabase??)
            // Shouldn't have to change any of the other code, just the part that's different
        }
    }
}
