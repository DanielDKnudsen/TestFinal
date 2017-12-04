using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ObserverPatternVol2
{
    public abstract class MålingContainerSubject
    {
        private List<IMålingObserver> _observers = new List<IMålingObserver>();
        public void Attach(IMålingObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IMålingObserver observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify(MålingDTO _mdto)
        {
            foreach (var observer in _observers)
            {
                observer.Update(_mdto);
            }
        }
    }
}
