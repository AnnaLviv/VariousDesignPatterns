using Observer.Subject;

namespace Observer.ObserverElements
{ 
    public abstract class AnimalBase : IObserver
    {
        protected AnimalBase(Color color)
        {
            ColorImplementation = color;
            ColorImplementation.RegisterObserver(this);
        }

        protected Color ColorImplementation { get; }

        public abstract void Update(IColorInterface consoleColor);

    }
}
