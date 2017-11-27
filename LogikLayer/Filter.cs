using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{
    public class Filter
    {
        public IFilter _filter;
        public Filter(IFilter filter)
        {
            _filter = filter;
        }
        public double FiltrerListe(List<double> konverteretListe)
        {
            return _filter.Filtrer(konverteretListe);
        }
    }
}
