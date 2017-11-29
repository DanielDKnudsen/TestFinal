using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikLayer
{
    class StandardAfvigelse
    {
        public double standardAfvigelse(List<double> Nulpunktsdata)
        {
            double gnms = Nulpunktsdata.Sum() / Nulpunktsdata.Count;
            double afvigelse = Nulpunktsdata.Select(val => (val - gnms) * (val - gnms)).Sum();
            double sd = Math.Sqrt(afvigelse / Nulpunktsdata.Count);
            return sd;
        }
    }
}
