using Command.CommandImplementations;

namespace Command
{
    /// <summary>
    ///  Invoker Object
    /// </summary>
    public class RemoteControl
    {
        private const int NumberOfSlots = 7;
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[NumberOfSlots];
            offCommands = new ICommand[NumberOfSlots];
            var noCommand = new NoCommand();
            for(var i=0;i<NumberOfSlots;i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommands(int slotNumber, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slotNumber] = onCommand;
            offCommands[slotNumber] = offCommand;
        }

        public void OnButtonWasPushed(int slotNumber)
        {
            onCommands[slotNumber].Execute();
            undoCommand = onCommands[slotNumber];
        }

        public void OffButtonWasPushed(int slotNumber)
        {
            offCommands[slotNumber].Execute();
            undoCommand = offCommands[slotNumber];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
        }
    }
}
