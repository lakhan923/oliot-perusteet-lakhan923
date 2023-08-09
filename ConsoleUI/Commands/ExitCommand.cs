using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    class ExitCommand:ICommand
    {
        public string Name { get { return "exit"; } }
        public string HelpText { get { return "Exit ConsolePlus instance."; } }

        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return "Exiting.";
        }
    
    }
}
