using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using LogikLayer.BTMåler;
using ObserverPatternVol2;

namespace LogikLayer
{
    public class Consumer
    {
        private MålingDTO M1 = new MålingDTO();
        private readonly ConcurrentQueue<Bufferblock> _dataQueue;
        private Converter convert;
        private Filter filter;
        public IFilter Ifilter { get; set; }
        public DataContainer _dct;
        private List<double> test = new List<double>();
        private List<double> konverteretListe = new List<double>();
        public bool kør { get; set; } 


        public Consumer(ConcurrentQueue<Bufferblock> dataQueue, IFilter iFilter,DataContainer DCT, BTMålerController BTMålerController, UdregnKalibrering UdKal)
        {
            Ifilter = iFilter;
            _dataQueue = dataQueue;
            _dct = DCT;
            convert = new Converter(BTMålerController, UdKal);
            filter = new Filter(iFilter,_dct);
        }

        public void Run()
        {
            while (kør)
            {
                Bufferblock B1;
                    while (!_dataQueue.TryDequeue(out B1))
                {
                    Thread.Sleep(0);
                }
                M1.Data = B1.Datalist;
                konverteretListe = convert.ConvertList(M1.Data);
                SendTilLogikLag();
                filter.FiltrerListe(Ifilter.Filtrer(konverteretListe));
                konverteretListe.Clear();
            }
        }

        public void GetNPJ(double NPJ)
        {
            convert.SetNPJ(NPJ);
        }

        public List<double> SendTilLogikLag()
        {
            return konverteretListe;
        }
        

        public void GetKalib(KalibreringDTO Kalib)
        {
            convert.SetKalib(Kalib.slope);
        }
        

        public double GetSlope(KalibreringDTO KalibDTO)
        {
            return convert.GetSlope(KalibDTO);
        }
    }
}
