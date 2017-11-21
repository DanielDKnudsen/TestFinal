using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;

namespace LogikLayer
{
    class Consumer
    {
        private MålingDTO M1 = new MålingDTO();
        private readonly ConcurrentQueue<Bufferblock> _dataQueue;

        public Consumer(ConcurrentQueue<Bufferblock> dataQueue)
        {
            _dataQueue = dataQueue;
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

                M1.Data = B1.Datalist;
            }

            
        }
    }
}
