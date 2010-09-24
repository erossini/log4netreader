using System.Collections.Generic;

namespace LogReader.Models.Observers
{
    public abstract class Subject
    {
        readonly List<IObserver> _observers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }
        
        public void NotifyObservers(object arg)
        {
            _observers
                .ForEach(x => x.Notify(arg));
        }
    }
}