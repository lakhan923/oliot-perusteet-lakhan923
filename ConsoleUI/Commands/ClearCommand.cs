using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    class ClearCommand:ICommand
    {
        public string Name { get { return "clear"; } }
        public string HelpText { get { return "Clears the console screen."; } }
      
        public string? Execute(string[] args)
        {
            Console.Clear();
            return null;
        }
    }
}
