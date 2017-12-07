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

        public DataProducer(ConcurrentQueue<Bufferblock> dataQueue)
        {
            _dataQueue = dataQueue;
            _data = new FakeDAQ();

        }

        public void Run()
        {
            while (true)
            {
                Bufferblock B1 = new Bufferblock();
                B1.Datalist = _data.CollectNulpunktsListe().Data;
                _dataQueue.Enqueue(B1);
                Thread.Sleep(50);
                
            }
        }
    }
}
