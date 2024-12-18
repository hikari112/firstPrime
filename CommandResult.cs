namespace PrimeTime
{
    public struct CommandResult
    {
        public Command Command { get; }
        public string Argument { get; }

        public CommandResult(Command command, string argument)
        {
            Command = command;
            Argument = argument;
        }
    }
}