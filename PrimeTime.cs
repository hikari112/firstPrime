

namespace PrimeTime
{
    class PrimeTime
    {
        static void Main(string[] args)
        {
            var commandHandler = new CommandHandler();
            var displayHandler = new DisplayHandler();
            var primeCheck = new PrimeCheck(displayHandler);

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
