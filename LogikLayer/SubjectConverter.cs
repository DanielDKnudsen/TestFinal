using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{
    public class SubjectConverter
    {
        private List<IConvert> _observers;
        protected void Notify(List<double> konverteretListe)
        {
            foreach (var observer in _observers)
            {
                observer.Update(konverteretListe);
            }
        }

        public void Attach(IConvert observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IConvert observer)
        {
            _observers.Remove(observer);
        }
    }
}
