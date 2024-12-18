
namespace PrimeTime
{
    public class DisplayHandler
    {
        private void WaitClear()
        {
            Console.ReadKey();
            Console.Clear();
        }

        private void InvalidCommand()
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

                case CommandResult.CheckPrime:
                    Console.WriteLine($"Checking if {command.Argument} is prime...");
                    break;

                case CommandResult.NewDivisor:
                    Console.WriteLine($"Checking {command.Argument} for divisibility: ");
                    break;

                case CommandResult.NotDivisible:
                    Console.WriteLine(" Is not divisible.");
                    break;

                case CommandResult.IsPrime:
                    Console.WriteLine($"{command.Argument} is prime!");
                    WaitClear();
                    break;

                case CommandResult.IsNotPrime:
                    Console.WriteLine(" Is divisible.");
                    Console.WriteLine($"{command.Argument} is not prime!");
                    WaitClear();
                    break;

                case CommandResult.InvalidArg:
                    Console.WriteLine($"{command.Argument} is an invalid argument.")
                    WaitClear();
                    break;

                case CommandResult.Help:
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

                case CommandResult.Unknown:
                    Console.Clear();
                    InvalidCommand();
                    break;

                default:
                    InvalidCommand();
                    break;
            }
        }
    }
}

