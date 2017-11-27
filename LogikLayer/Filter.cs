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
        private List<double> filtreretListe = new List<double>();
        public IFilter _filter;
        public Filter(IFilter filter)
        {
            _filter = filter;
            lav0Liste();
        }
        public void FiltrerListe(List<double> konverteretListe)
        {
            filtreretListe.Add(_filter.Filtrer(konverteretListe));
            if (filtreretListe.Count > 100)
            {
                filtreretListe.RemoveAt(0);
            }
            Notify(filtreretListe);
        }

        private void lav0Liste()
        {
            for (int i = 0; i < 100; i++)
            {
                filtreretListe.Add(0);
            }
        }

    }
}
