

namespace PrimeTime
{
    class PrimeTime
    {
        static void Main(string[] args)
        {
            var commandHandler = new CommandHandler();
            var displayHandler = new DisplayHandler();
            var primeCheck = new PrimeCheck(displayHandler);


            CommandResult command;
            command = new CommandResult(Command.Main, "");

            do
            {

                displayHandler.Display(command);
                command = commandHandler.GetNextCommand();

                switch (command.Command)
                {
                    case Command.CheckPrime:
                        command = primeCheck.Run(command);
                        break;

                    case Command.Exit:
                        displayHandler.Display(command);
                        break;

                    default:
                        displayHandler.Display(command);
                        command = new CommandResult(Command.Main, "");
                        break;

                }
            } while (command.Command != Command.Exit);
        }
    }
}
