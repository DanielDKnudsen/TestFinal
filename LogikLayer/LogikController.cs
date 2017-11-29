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


namespace LogikLayer
{
    public class LogikController : ILogikLayer
    {

        private IDataLayer DL;
        private IPresentationLayer PL;
        private BTMålerController BTMålercontroller;
        private Kalibrering kalib;
        private Consumer _consumer;
        private Nulpunktsjustering NPJ;

        public LogikController(IDataLayer dl, Consumer consumer)
        {
            DL = dl;
            kalib = new Kalibrering(DL);
            _consumer = consumer;
            NPJ = new Nulpunktsjustering(DL);
        }

        public void SetNPJ()
        {
            DL.GemNPJ(NPJ.NulpunktBeregnet());
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
            IFilter f;
            if (Filter == "DigFilter")
            {
                f = new DigFilter();
            }
            else
            {
                f = new RawFilter();
            }
            _consumer.Ifilter = f;
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
