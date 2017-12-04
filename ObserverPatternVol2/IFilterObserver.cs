using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternVol2
{
     public interface IFilterObserver
    {
        void Update(Queue<double> _queue);
    }
}
