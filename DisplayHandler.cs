
namespace PrimeTime
{
    public class DisplayHandler
    {
        private void WaitClear()
        {
            Console.ReadKey();
            Console.Clear();
        }

        private void UnknownCommand()
        {
            Console.WriteLine("Invalid Command...");
            WaitClear();
        }

        private void Display(CommandResult command)
        {
            Console.Clear();

            switch (command.Command)
            {
                case Command.Main:
                    Console.Clear();
                    Console.WriteLine("Welcome to Prime Checker!");
                    Console.WriteLine("Type 'help' for commands");
                    break;

                case Command.CheckPrime:
                    Console.WriteLine($"Checking if {command.Argument} is prime...");
                    break;

                case Command.NewDivisor:
                    Console.WriteLine($"Checking {command.Argument} for divisibility: ");
                    break;

                case Command.NotDivisible:
                    Console.WriteLine(" Is not divisible.");
                    break;

                case Command.IsPrime:
                    Console.WriteLine($"{command.Argument} is prime!");
                    WaitClear();
                    break;

                case Command.IsNotPrime:
                    Console.WriteLine(" Is divisible.");
                    Console.WriteLine($"{command.Argument} is not prime!");
                    WaitClear();
                    break;

                case Command.InvalidArgument:
                    Console.WriteLine($"{command.Argument} is an invalid argument.")
                    WaitClear();
                    break;

                case Command.InvalidCommand:
                    Console.WriteLine($"{command.Command} is and invalid command.");
                    WaitClear();
                    break;

                case Command.Help:
                    Console.Clear;
                    Console.WriteLine("Available commands:");
                    Console.WriteLine("check <number> - Check if a number is prime");
                    Console.WriteLine("help - Show this help message");
                    Console.WriteLine("exit - Exit the program");
                    WaitClear();
                    break;

                case Command.Exit:
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    break;

                case Command.Unknown:
                    Console.Clear();
                    UnknownCommand();
                    break;

                default:
                    UnknownCommand();
                    break;
            }
        }
    }
}

