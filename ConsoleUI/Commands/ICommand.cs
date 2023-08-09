using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Commands
{
    public interface ICommand
    {
        string Name { get;  }

        string HelpText { get;  }

       // bool IsPrivileged { get;  }

        string? Execute(string[] args);
    }
}
