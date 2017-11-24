using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace LogikLayer
{
    public class SubjectTransferData
    {
        private List<IDataObserver> _observers = new List<IDataObserver>();
        public void Notify(MålingDTO mDTO)
        {
            foreach (var observer in _observers)
            {
                observer.Update(mDTO);
            }
        }

        public void Attach(IDataObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IDataObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
