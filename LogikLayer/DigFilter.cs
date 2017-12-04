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
        private double total;
        private List<double> Sidste2Punkter = new List<double>();
        private double average;

        public DigFilter()
        {
            ClearList();
        }

        public List<double> Filtrer(List<double> RawList)
        {
            List<double> FiltretetRawListe = new List<double>();
            List<double> DigitalListe = new List<double>();
            List<double> MovingAverage = new List<double>();
                
            FiltretetRawListe = FiltrerRaw(RawList);

            if (Sidste2Punkter.Count == 2)
            {
                DigitalListe.Add(Sidste2Punkter[0]);
                DigitalListe.Add(Sidste2Punkter[1]);
            }

            foreach (var item in FiltretetRawListe)
            {
                DigitalListe.Add(item);
            }

            for (int i = 0; i < DigitalListe.Count-2; i++)
            {
                MovingAverage.Add((DigitalListe[i] + DigitalListe[i + 1] + DigitalListe[i + 2]) / 3);
            }
            Sidste2Punkter.Clear();
            Sidste2Punkter.Add(DigitalListe[DigitalListe.Count-2]);
            Sidste2Punkter.Add(DigitalListe[DigitalListe.Count-1]);
            return MovingAverage;
        }

        private List<double> FiltrerRaw(List<double> konverteretListe)
        {
            List<double> RawListe = new List<double>();
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
            return RawListe;
        }

        private void ClearList()
        {
            
        }
    }
}
