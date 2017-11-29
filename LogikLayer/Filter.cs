using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{
    public class Filter : FilterSubject
    {
        private Queue<double> filtreretKø = new Queue<double>();
        public IFilter _filter;
        public Filter(IFilter filter)
        {
            _filter = filter;
            lav0Kø();
        }
        public void FiltrerListe(double konverteretListe)
        {
            filtreretKø.Enqueue(konverteretListe);
            if (filtreretKø.Count > 100)
            {
                filtreretKø.Dequeue();
            }
            Notify(filtreretKø);
        }

        
        private void lav0Kø()
        {
            for (int i = 0; i < 100; i++)
            {
                filtreretKø.Enqueue(0);
            }
        }

    }
}
