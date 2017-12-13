using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using Interfaces;


namespace DataLayer
{
    public class DataProducer
    {
        private readonly ConcurrentQueue<Bufferblock> _dataQueue;
        private IDAQ _data;
        private List<double> test = new List<double>();
        public bool kør { get; set; }

        public DataProducer(ConcurrentQueue<Bufferblock> dataQueue)
        {
            _dataQueue = dataQueue;
            _data = new DAQ();
        }

        public void Run()
        {
            while (kør)
            {
                Bufferblock B1 = new Bufferblock();
                B1.Datalist = _data.CollectNulpunktsListe().Data;
                _dataQueue.Enqueue(B1);
                //Thread.Sleep(50);

                for (int i = 0; i < B1.Datalist.Count; i++)
                {
                    test.Add(B1.Datalist[i]);
                }

                if (test.Count == 5000)
                {
                    int t = 1;
                }
            }
        }
    }
}
