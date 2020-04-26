namespace Command.CommandImplementations
{
    public class MacroCommand:ICommand
    {
        private readonly ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var command in commands)
                command.Execute();
        }

        public void Undo()
        {
            foreach (var command in commands)
                command.Undo();
        }
    }
}
