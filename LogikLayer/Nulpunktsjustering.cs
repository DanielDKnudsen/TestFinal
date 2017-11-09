using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace LogikLayer
{

    //public class Nulpunktsjustering
    //{
    //    private IDataLayer DL;

    //    private List<double> Nulpunktsdata = new List<double>();
    //    public Nulpunktsjustering(IDataLayer dl)
    //    {
    //        DL = dl;
    //        Nulpunktsdata1 = DL.CollectNulpunktsListe();
    //    }

    //    public void Nulpunktsjuster()
    //    {
            
    //        if (standardAfvigelse() <= 0.2)
    //        {
                
    //        }
    //    }

    //    private double standardAfvigelse()
    //    {
    //        List<double> Nulpunktsdata = new List<double>();

    //        Nulpunktsdata.Add(4);
    //        Nulpunktsdata.Add(5);
    //        Nulpunktsdata.Add(4);
    //        Nulpunktsdata.Add(5);
    //        Nulpunktsdata.Add(4);

    //        double gnms = Nulpunktsdata.Sum() / Nulpunktsdata.Count;
    //        double afvigelse = Nulpunktsdata.Select(val => (val - gnms) * (val - gnms)).Sum();
    //        double sd = Math.Sqrt(afvigelse / Nulpunktsdata.Count);
    //        return sd;
    //    }
    //}
}
