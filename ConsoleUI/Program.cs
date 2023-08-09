// See https://aka.ms/new-console-template for more information
using ConsoleUI.Model;
using ConsoleUI.Commands;

public class Program
{
    public const string Version = "1.0.0.0";

    public static CommandRegistry<ICommand> Registry = new CommandRegistry<ICommand>();

    /// <summary>
    /// The application's entry point.
    /// Edited from https://github.com/ArtOfCode-/ConsolePlus
    /// </summary>
    /// <param name="args">The command-line arguments passed to the program.</param>
    public static void Main(string[] args)
    {
        CommandHandler.RegisterCommands();


        Console.WriteLine("ConsoleUI v." + Version);
        while (true)
        {
            Console.Write(">>> ");
            string line = Console.ReadLine();
          
                List<string> parts = line.Split(' ').ToList<string>();
                string commandName = parts[0];
                parts.RemoveAt(0);
                string[] commandArgs = parts.ToArray<string>();

                try
                {
                    string? result = Registry.Execute(commandName, commandArgs);
                    if (result != null)
                    {
                        Console.WriteLine("[{0}] {1}", commandName, result);
                    }
                }
                catch (CommandNotFoundException)
                {
                    Console.WriteLine("[ConsolePlus] No such command.");
                }
            
     
        }
    }

}


    
