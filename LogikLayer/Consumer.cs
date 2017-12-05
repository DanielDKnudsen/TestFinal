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
        public Consumer(ConcurrentQueue<Bufferblock> dataQueue, IFilter iFilter,DataContainer DCT, BTMålerController BTMålerController)
        {
            Ifilter = iFilter;
            _dataQueue = dataQueue;
            _dct = DCT;
            convert = new Converter(BTMålerController);
            filter = new Filter(iFilter,_dct);
        }

        public void Run()
        {
            while (true)
            {
                Bufferblock B1;
                    while (!_dataQueue.TryDequeue(out B1))
                {
                    Thread.Sleep(0);
                }
                List<double> konverteretListe = new List<double>();
                M1.Data = B1.Datalist;
                konverteretListe = convert.ConvertList(M1.Data);
                filter.FiltrerListe(Ifilter.Filtrer(konverteretListe));
                

            }
        }

        public void GetNPJ(double NPJ)
        {
            convert.SetNPJ(NPJ);
        }
    }
}
