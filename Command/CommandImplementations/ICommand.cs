namespace Command.CommandImplementations
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
