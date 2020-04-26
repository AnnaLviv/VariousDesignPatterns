using Command.Devices;

namespace Command.CommandImplementations
{
    public class GarageDoorOpenCommand:ICommand
    {
        public GarageDoor GarageDoor { get; }

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute() => GarageDoor.Up();

        public void Undo() => GarageDoor.Undo();
    }
}
