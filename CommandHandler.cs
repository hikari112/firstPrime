using System;

namespace PrimeTime
{
    public class CommandHandler
    {
        private string GetUserInput()
        {
            Console.Write("> ");
            string? command = Console.ReadLine();
            return command ?? "";
        }

        private Command ToCommand(string input)
        {
            string command = input.ToLower();

            switch(command)
            {
                case "check":
                    return Command.CheckPrime;
                case "help":
                    return Command.Help;
                case "exit":
                    return Command.Exit;
                default:
                    return Command.Unknown;
            }
        }

        private CommandResult ParseCommand(string input)
        {
            string[] userInput = input.Trim().Split(' ');

            bool fullCommand = userInput.Length >= 2;
            bool halfCommand = userInput.Length == 1;

            if (fullCommand)
            {
                return new CommandResult(ToCommand(userInput[0]), userInput[1]);
            }

            else if (halfCommand)
            {
                return new CommandResult(ToCommand(userInput[0]), "");
            }
            else
            {
                return new CommandResult(Command.Unknown, "");
            }
        }

        public CommandResult GetNextCommand()
        {
            string input = GetUserInput();
            return ParseCommand(input);
        }
    }
}
