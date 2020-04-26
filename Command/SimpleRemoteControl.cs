using Command.CommandImplementations;

namespace Command
{       
    /// <summary>
    /// Invoker Object
    /// </summary>
    public class SimpleRemoteControl
    {
        private ICommand slot;
        
        public void SetCommand(ICommand slot)
        {
            this.slot = slot;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }

    }
}
