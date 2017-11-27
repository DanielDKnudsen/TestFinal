using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{
    public class RawFilter : IFilter
    {
        public double Filtrer(List<double> konverteretListe)
        {
            return konverteretListe.Average();
        }
    }
}
