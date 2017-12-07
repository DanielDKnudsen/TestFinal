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
        private double total;
        private List<double> listeliste = new List<double>();
        public List<double> Filtrer(List<double> konverteretListe)
        {
            List<double> RawListe = new List<double>();

            for (int i = 0; i < konverteretListe.Count; i++)
            {
                listeliste.Add(konverteretListe[i]);
            }


            for (int i = 0; i < konverteretListe.Count - 1; i += 10)
            {
                total = 0;
                for (int j = 0; j <= 9; j++)
                {
                    total += konverteretListe[i + j];
                }
                total = total / 10;
                RawListe.Add(total);
            }

            if (listeliste.Count > 4999)
            {
                int t = 4;
            }

            return RawListe;
        }
    }
}
