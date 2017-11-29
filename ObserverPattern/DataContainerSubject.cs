using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class DataContainerSubject 
    {
        private List<IFilterObserver> _observers = new List<IFilterObserver>();
        public void Attach(IFilterObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IFilterObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify(Queue<double> _queue)
        {
            foreach (var observer in _observers)
            {
                observer.Update(_queue);
            }
        }
    }
}
