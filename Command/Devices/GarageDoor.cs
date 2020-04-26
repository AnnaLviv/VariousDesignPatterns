using Command.Devices.States;

namespace Command.Devices
{
    public class GarageDoor
    {
        public GarageDoorState GarageDoorState { get; private set; }
        private GarageDoorState previousGarageDoorState;
        public LightState LightState { get; private set; }
       
        public GarageDoor()
        {
            GarageDoorState = GarageDoorState.Stopped;
            LightState = LightState.Off;
        }

        public void Up()
        {
            previousGarageDoorState = GarageDoorState;
            GarageDoorState = GarageDoorState.MoveUp;
        }

        public void Down()
        {
            previousGarageDoorState = GarageDoorState;
            GarageDoorState = GarageDoorState.MoveDown;
        }

        public void Stop()
        {
            previousGarageDoorState = GarageDoorState;
            GarageDoorState = GarageDoorState.Stopped;
        }

        public void Undo()
        {
            GarageDoorState = previousGarageDoorState;
        }

        public void LightOn() => LightState = LightState.On;

        public void LightOff() => LightState = LightState.Off;
    }
}
