using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{
    public class FilterSubject
    {
        private List<IFilterObserver> _observers = new List<IFilterObserver>();
        public void Notify(List<double> punkt)
        {
            foreach (var observer in _observers)
            {
                observer.Update(punkt);
            }
        }

        public void Attach(IFilterObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IFilterObserver observer)
        {
            _observers.Remove(observer);
        }
            
    }
}
