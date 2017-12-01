using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{
    public class DigFilter : IFilter
    {

        
        public List<double> Filtrer(List<double> konverteretListe)
        {
            List<double> DigListe = new List<double>();
            DigListe.Add(konverteretListe.Average());
            return DigListe;
        }
    }
}
