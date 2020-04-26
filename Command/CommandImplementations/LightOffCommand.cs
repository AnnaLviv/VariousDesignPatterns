using Command.Devices;

namespace Command.CommandImplementations
{
    public class LightOffCommand : ICommand
    {
        public Light Light { get; }

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}
