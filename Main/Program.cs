using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Interfaces;
using LogikLayer;
using PresentationLayer;
using Projekt_v1._1;
using DTO;
using ObserverPattern;

namespace Main
{
    class Program
    {
        private static ILogikLayer LL;
        private static IDataLayer DL;
        private static IPresentationLayer PL;
        private static Consumer _consumer;
        private static ConcurrentQueue<Bufferblock> _dataqueue;
        private static IFilter _ifilter;
        private static DataProducer _producer;
        private static DataContainer _dataContainer;

        static void Main(string[] args)
        {
            Program currentApp = new Program();
        }

        public Program()
        {
            _dataContainer = new DataContainer();
            _ifilter = new RawFilter();
            _dataqueue = new ConcurrentQueue<Bufferblock>();
            _consumer = new Consumer(_dataqueue, _ifilter,_dataContainer);
            _producer = new DataProducer(_dataqueue);

            DL = new DataController(_producer);
            LL = new LogikController(DL, _consumer,_dataContainer);
            PL = new PresentationLayerController(LL,_dataContainer);
            PL.startUpGUI();
        }
    }
}
