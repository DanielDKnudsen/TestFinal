using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IFilterObserver
    {
        void Update(Queue<double> _queue);
    }
}
