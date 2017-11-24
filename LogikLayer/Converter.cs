using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using LogikLayer.BTMåler;

namespace LogikLayer
{
    public class Converter
    {
        public List<double> KonverteretListe = new List<double>();
        private IDataLayer idal;
        public void ConvertList(List<double> RawList)
        {
            foreach (var item in RawList)
            {
                KonverteretListe.Add(item);
            }
            lavListe();
        }

        public void lavListe()
        {
            if (KonverteretListe.Count > 5000)
            {
                BTMålerController BTC = new BTMålerController(idal);
                BTC.StartTråde(KonverteretListe);
            }

        }
    }
}
