using Observer.Subject;

namespace Observer.ObserverElements
{ 
    public class Dog : AnimalBase
    {
        public Dog(Color color) : base(color)
        {
        }

        public string Woof { get; private set; }

        public override void Update(IColorInterface consoleColor)
        {
            Woof = $"Woof {consoleColor.GetState()}";
        }
    }
}
