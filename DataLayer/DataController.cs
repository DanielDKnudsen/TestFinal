using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace DataLayer
{
    public class DataController : IDataLayer
    {
        private DataProducer _producer;
        private XMLGemNulpunkt NPJ;
        private IDAQ IDaq;


        public DataController(DataProducer producer)
        {
            _producer = producer;
            NPJ = new XMLGemNulpunkt();
            IDaq = new FakeDAQ();
        }

        public void GemPatient(PatientDTO PDTO)
        {
            
        }

        public void GemKalibrering(KalibreringDTO KalibDTO)
        {
            
        }

        public void GemNPJ(double Nulpunkt)
        {
            NPJ.GemXMLNulpunkt(Nulpunkt);
        }

        public void StartProducerTråd()
        {
            Thread producerThread = new Thread(_producer.Run);
            producerThread.Start();
        }

        public List<double> LavKalibrering(int mmHg)
        {
            Hent_Kalibrering hentKalib = new Hent_Kalibrering();
            return hentKalib.LavKalibrering(mmHg);
        }

        public MålingDTO startMålingPrøve()
        {
            
            return IDaq.CollectNulpunktsListe();
        }

        public MålingDTO Start()
        {
            return IDaq.CollectNulpunktsListe();
        }
    }
}
