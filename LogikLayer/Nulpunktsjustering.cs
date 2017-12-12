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
        private string Fortsæt;
        private double _npj;


        private List<double> Nulpunktsdata = new List<double>();
        public Nulpunktsjustering(IDataLayer dl)
        {
            DL = dl;
        }

        public void Nulpunktsjuster()
        {
            Nulpunktsdata = DL.startMålingPrøve().Data;
            StandardAfvigelse sd = new StandardAfvigelse();
            if (sd.standardAfvigelse(Nulpunktsdata) <= 0.8)
            {
                Fortsæt = "Nulpunktsjustering er foretaget. Værdien er " + NulpunktBeregnet() / (5 * 0.000005 * 736.294) + " mmHg" + ". " +
                       "Vil du fortsætte?";
            }
            else
            {
                Fortsæt = "Nulpunktsjustering er foretaget. Der var stor usikkerhed i måling, værdien blev " +
                          NulpunktBeregnet() / (5 * 0.000005 * 736.294) +  " mmHg" + ". Vil du fortsætte?";
            }
        }

        public string FortsætString()
        {
            return Fortsæt;
        }

        public double NulpunktBeregnet()
        {
           _npj = (Nulpunktsdata.Sum() / Nulpunktsdata.Count);
            return _npj;
        }
    }
}
