using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DataLayer
{
    public class SubjectDAQ
    {
        private List<IDataObserver> _observers;
        public void Attach(IDataObserver observer)
        {
           _observers.Add(observer);
        }

        public void Detach(IDataObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
