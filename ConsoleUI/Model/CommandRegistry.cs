using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Commands;

namespace ConsoleUI.Model
{
    public class CommandRegistry<T>
        where T : ICommand
    {
        private Dictionary<string, T> register;

        public Dictionary<string, T> Register { get => register;}

        public CommandRegistry()
        {
            register = new Dictionary<string, T>();
        }

        public CommandRegistry(params T[] commands)
            : this()
        {
            foreach (T command in commands)
            {
                register.Add(command.Name, command);
            }
        }

        public T GetCommand(string name)
        {
            if (register.ContainsKey(name))
            {
                return register[name];
            }
            else
            {
                throw new CommandNotFoundException(name);
            }
        }

        public string? Execute(string name, string[] args)
        {
            if (register.ContainsKey(name))
            {
                return register[name].Execute(args);
            }
            else
            {
                throw new CommandNotFoundException(name);
            }
        }

        public void RegisterCommand(T command)
        {
            register.Add(command.Name, command);
        }
    }
}
