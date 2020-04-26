using Command.Devices.States;

namespace Command.Devices
{
    public class Light
    {
        public LightState LightState { get; private set; }

        public Light()
        {
            LightState = LightState.Off;
        }

        public void On() => LightState = LightState.On;

        public void Off() => LightState = LightState.Off;
    }
}
