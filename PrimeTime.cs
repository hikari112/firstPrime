

namespace PrimeTime
{
    class PrimeTime
    {
        static void Main(string[] args)
        {
            var commandHandler = new CommandHandler();
            var primeCheck = new PrimeCheck();
            var displayHandler = new DisplayHandler();

            displayHandler.Display(new CommandResult(Command.Main, ""));

            CommandResult command;

            do
            {
                command = commandHandler.GetNextCommand();

                if (command.Command == Command.CheckPrime)
                {
                    command = primeCheck.Run(command);
                }
                else
                {
                    displayHandler.Display(command);
                }
            } while (command.Command != Command.Exit);
        }
    }
}
