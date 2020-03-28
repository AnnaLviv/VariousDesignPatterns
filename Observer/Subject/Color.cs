using Observer.ObserverElements;
using System;
using System.Collections.Generic;

namespace Observer.Subject
{
    public class Color : IColorInterface
    {
        public Color()
        {
            observers = new List<IObserver>();

        }
        public ConsoleColor GetState()
        {
            return ColorProperty;
        }

        public void SetState(ConsoleColor color)
        {
            if(color!= ColorProperty)
            {
                ColorProperty = color;
                NotifyObservers();
            }
           
        }


        private IList<IObserver> observers;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.Update(this);
        }

        public ConsoleColor ColorProperty
        {
            get; private set;
        }

    }
}
