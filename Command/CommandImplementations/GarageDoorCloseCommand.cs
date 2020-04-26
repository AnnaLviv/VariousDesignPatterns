using Command.Devices;

namespace Command.CommandImplementations
{
    public class GarageDoorCloseCommand : ICommand
    {
        public GarageDoor GarageDoor { get; }

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute() => GarageDoor.Down();

        public void Undo() => GarageDoor.Undo();
    }
}
