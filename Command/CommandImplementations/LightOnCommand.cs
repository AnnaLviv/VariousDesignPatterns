using Command.Devices;

namespace Command.CommandImplementations
{
    public class LightOnCommand : ICommand
    {
        public Light Light { get; }

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
