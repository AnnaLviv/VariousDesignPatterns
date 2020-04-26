using Command.Devices;

namespace Command.CommandImplementations
{
    public class GarageDoorLightOnCommand : ICommand
    {
        public GarageDoor GarageDoor { get; }

        public GarageDoorLightOnCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute() => GarageDoor.LightOn();

        public void Undo() => GarageDoor.LightOff();
    }
}

