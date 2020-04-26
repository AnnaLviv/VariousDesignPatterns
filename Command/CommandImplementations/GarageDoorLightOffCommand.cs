using Command.Devices;

namespace Command.CommandImplementations
{
    public class GarageDoorLightOffCommand : ICommand
    {
        public GarageDoor GarageDoor { get; }

        public GarageDoorLightOffCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public void Execute() => GarageDoor.LightOff();

        public void Undo() => GarageDoor.LightOn();
    }
}
