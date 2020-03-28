using Observer.ObserverElements;
using System;

namespace Observer.Subject
{
    public interface IColorInterface
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();

        ConsoleColor GetState();

        void SetState(ConsoleColor color);

    }
}
