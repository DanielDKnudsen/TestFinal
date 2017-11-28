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

namespace LogikLayer
{
    public class Consumer
    {
        private MålingDTO M1 = new MålingDTO();
        private readonly ConcurrentQueue<Bufferblock> _dataQueue;
        private Converter convert;
        public IFilter Ifilter { get; set; }
        public Consumer(ConcurrentQueue<Bufferblock> dataQueue, IFilter iFilter)
        {
            Ifilter = iFilter;
            _dataQueue = dataQueue;
            convert = new Converter();
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
                Ifilter.Filtrer(konverteretListe);
            }
        }
    }
}
