using System;

namespace Command.CommandImplementations
{
    /// <summary>
    /// Null object for Command.
    /// Designed to avoid handiling null from the client.
    /// </summary>
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("There is nothing to execute");
        }

        public void Undo()
        {
            Console.WriteLine("There is nothing to undo");
        }
    }
}
