using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using ObserverPattern;

namespace LogikLayer
{
    public class Filter : DataContainerSubject
    {
        private Queue<double> filtreretKø = new Queue<double>();
        public IFilter _filter;
        public DataContainer _dct;
        public Filter(IFilter filter,DataContainer DCT)
        {
            _filter = filter;
            lav0Kø();
            _dct = DCT;

        }
        public void FiltrerListe(List<double> konverteretListe)
        {
            foreach (var item in konverteretListe)
            {
                filtreretKø.Enqueue(item);
                if (filtreretKø.Count > 200)
                {
                    filtreretKø.Dequeue();
                }
            }
           _dct.Done(filtreretKø);
        }

        
        private void lav0Kø()
        {
            for (int i = 0; i < 200; i++)
            {
                filtreretKø.Enqueue(1);
            }
        }

        

    }
}
