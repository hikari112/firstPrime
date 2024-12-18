
using System;

namespace PrimeTime
{
    public class PrimeCheck
    {
        private int numberToCheck;
        private int checkLimit;
        var displayHandler = new DisplayHandler();

        private CommandResult Check(CommandResult command)
        {
            displayHandler.Display(command);

            switch(command.Command)
            {
                case Command.CheckPrime:
                    numberToCheck = Math.Abs(int.Parse(command.Argument));

                    bool even = numberToCheck % 2 == 0;
                    bool isOne = numberToCheck == 1;
                    bool isZero = numberToCheck == 0;

                    if (even || isOne || isZero)
                    {
                        return new CommandResult(Command.IsNotPrime, command.Argument);
                    }
                    
                    else
                    {
                        checkLimit = (int) Math.Floor(Math.Sqrt((double) numberToCheck));
                        return Check(new CommandResult(Command.NewDivisor, "3"));

                    }

                case Command.NewDivisor:
                    int divisor = int.Parse(command.Argument);

                    if (divisor >= checkLimit)
                    {
                        return Check(new CommandResult(Command.IsPrime, numberToCheck.ToString()));
                    }


                    if (numberToCheck % divisor == 0)
                    {
                        return Check(new CommandResult(Command.IsNotPrime, numberToCheck.ToString()));
                    }
                    else
                    {
                        displayHandler.Display(new CommandResult(Command.NotDivisible, ""));
                        int newDivisor = divisor + 2;
                        return Check(new CommandResult(Command.NewDivisor, newDivisor.ToString()));
                    }

                default:
                    return new CommandResult(Command.Main, "");

            }
        }

        public CommandResult Run(CommandResult command)
        {
            bool incorrectCommand = command.Command != CommandResult.CheckPrime;

            if (incorrectCommand)
            {
                displayHandler.Display(new CommandResult(Command.InvalidCommand, command.Argument));
                return new CommandResult(Command.Main, "");
            }

            bool emptyString = command.Argument == "";
            bool nan = !int.TryParse(command.Argument, out _);
            bool invalidArgument = emptyString || nan;

            if (invalidArgument)
            {
                displayHandler.Display(new CommandResult(Command.InvalidArgument, command.Argument));
                return new CommandResult(Command.Main, "");
            }

            else
            {
                return Check(command);
            }
        }
    }
}
