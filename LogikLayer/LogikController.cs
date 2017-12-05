using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;
using DTO;
using LogikLayer.BTMåler;
using ObserverPatternVol2;


namespace LogikLayer
{
    public class LogikController : ILogikLayer
    {

        private IDataLayer DL;
        private IPresentationLayer PL;
        private Kalibrering kalib;
        private Consumer _consumer;
        private Nulpunktsjustering NPJ;
        private Filter _filter;
        private DataContainer _dct;
        private bool tidFaktor;
        public LogikController(IDataLayer dl, Consumer consumer,DataContainer DCT)
        {
            DL = dl;
            kalib = new Kalibrering(DL);
            _consumer = consumer;
            _dct = DCT;
            NPJ = new Nulpunktsjustering(DL);
            _filter = new Filter(new RawFilter(), _dct);
        }

        public void SetNPJ()
        {
            DL.GemNPJ(NPJ.NulpunktBeregnet());
            _consumer.GetNPJ(NPJ.NulpunktBeregnet());
        }

        public string NulpunktStart()
        {
            NPJ.Nulpunktsjuster();
            return NPJ.FortsætString();
        }

        
        public void StartTråde()
        {
            Thread consumerThread = new Thread(_consumer.Run);
            consumerThread.Start();
            DL.StartProducerTråd();
        }

        public void GemKalibrering(KalibreringDTO KalibDTO)
        {
            DL.GemKalibrering(KalibDTO);
        }

        public void SetFilter(string Filter)
        {
            tidFaktor = false;
            IFilter f;
            if (Filter == "DigFilter")
            {
                f = new DigFilter();
                tidFaktor = true;
            }
            else
            {
                f = new RawFilter();
                tidFaktor = false;
            }
            _consumer.Ifilter = f;
            GetTidfaktor();
        }

        public bool GetTidfaktor()
        {
            return tidFaktor;
        }

        public bool StartKalibrering(int mmHg)
        {
            return kalib.startKalibrering(mmHg);
        }

        public void setKali(int mmHg)
        {
            kalib.setKali(mmHg);
        }


        public int RequestLogind(LogindDTO LDTO)
        {
            Logind Log = new Logind();
            return Log.CheckValues(LDTO);
        }
        public void GemPatient(PatientDTO PDTO)
        {
            DL.GemPatient(PDTO);
        }

    }
}
