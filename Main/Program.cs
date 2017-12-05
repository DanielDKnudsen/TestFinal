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
using LogikLayer.BTMåler;
using PresentationLayer;
using Projekt_v1._1;
using DTO;
using ObserverPatternVol2;

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
        private static MålingContainer _målingContainer;
        private static BTMålerController _BTcontroller;

        static void Main(string[] args)
        {
            Program currentApp = new Program();
        }

        public Program()
        {
            _målingContainer = new MålingContainer();
            _dataContainer = new DataContainer();
            _ifilter = new RawFilter();

            _BTcontroller = new BTMålerController(_målingContainer);
            _dataqueue = new ConcurrentQueue<Bufferblock>();
            _consumer = new Consumer(_dataqueue, _ifilter,_dataContainer, _BTcontroller);
            _producer = new DataProducer(_dataqueue);

            DL = new DataController(_producer);
            LL = new LogikController(DL, _consumer,_dataContainer);
            PL = new PresentationLayerController(LL,_dataContainer, _målingContainer);
            PL.startUpGUI();
        }
    }
}
