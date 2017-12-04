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
        private Filter _filter;
        private LogikController LC;
        private BTMålerController _BTMålerController;

        private double _npj;

        public Converter(BTMålerController BTMålerController)
        {
            _BTMålerController = BTMålerController;
        }


        public List<double> ConvertList(List<double> RawList)
        {
            foreach (var item in RawList)
            {
                KonverteretListe.Add((item - _npj) / (5 * 0.000005 * 736.294));
            }
            lavListe();
            return RawList;
        }

        public void lavListe()
        {
            if (KonverteretListe.Count > 5000)
            {
                _BTMålerController.StartTråde(KonverteretListe);
            }
        }

        public void SetNPJ(double NPJ)
        {
            _npj = NPJ;
        }
    }
}
