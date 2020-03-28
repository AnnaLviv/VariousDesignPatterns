using Observer.Subject;

namespace Observer.ObserverElements
{
    public class Cat : AnimalBase
    {
        public Cat(Color color):base( color)
        {
        }

        public string Miauw { get; private set; }

        public override void Update(IColorInterface consoleColor)
        {
            Miauw = $"Miauw {consoleColor.GetState()}";
        }
    }
}
