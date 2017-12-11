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
        private List<double> KonverteretListe = new List<double>();
        private List<int> TickCount = new List<int>();
        private IDataLayer idal;
        private Filter _filter;
        private LogikController LC;
        private BTMålerController _BTMålerController;
        private UdregnKalibrering _UdKal;

        private double _kalib;
        private double _npj;

        public Converter(BTMålerController BTMålerController, UdregnKalibrering UdKal)
        {
            _BTMålerController = BTMålerController;
            _UdKal = UdKal;
        }


        public List<double> ConvertList(List<double> RawList)
        {
            
            foreach (var item in RawList)
            {
                KonverteretListe.Add((item -_npj) / (5 * 0.000005 * 736.294));
            }
            lavListe();
            return RawList;
        }

        public void lavListe()
        {
            TickCount.Add(Environment.TickCount);

            if (KonverteretListe.Count > 5000)
            {
                FixListe();
                KonverteretListe.RemoveRange(0, 1000);
                TickCount.RemoveRange(0, 20);
            }
        }

        public void SetNPJ(double NPJ)
        {
            _npj = NPJ;
        }

        public void HentKalib(List<double> KalibListe)
        {
            _UdKal.GetKalibrering(KalibListe);
        }

        public void SetKalib(double Kalib)
        {
            _kalib = Kalib;
        }


        private void FixListe()
        {
            List<double> konverteretTrådliste = new List<double>();
            foreach (var item in KonverteretListe)
            {
                konverteretTrådliste.Add(item);
            }
            _BTMålerController.StartTråde(konverteretTrådliste, TickCount);
        }
    }
}
