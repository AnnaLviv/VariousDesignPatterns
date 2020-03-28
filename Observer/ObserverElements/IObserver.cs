using Observer.Subject;

namespace Observer.ObserverElements
{
    public interface IObserver
    {
         void Update(IColorInterface consoleColor);
    }
}
