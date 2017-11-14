using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{

    public class Nulpunktsjustering
    {
        private IDataLayer DL;

        private List<double> Nulpunktsdata = new List<double>();
        public Nulpunktsjustering(IDataLayer dl)
        {
            DL = dl;
            Nulpunktsdata = DL.startMålingPrøve().Data;
        }

        public string Nulpunktsjuster()
        {
            StandardAfvigelse sd = new StandardAfvigelse();
            if (sd.standardAfvigelse(Nulpunktsdata) >= 0.8)
            {
                return "Nulpunktsjustering er foretaget. Værdien er " + Nulpunktsdata.Sum() / Nulpunktsdata.Count + ". " +
                       "Vil du fortsætte?";
            }
            else
            {
                return "Nulpunktsjustering er foretaget. Der var stor usikkerhed i måling, værdien blev " +
                       Nulpunktsdata.Sum() / Nulpunktsdata.Count + ". Vil du fortsætte?";
            }
        }
    }
}
