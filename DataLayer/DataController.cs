using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using Interfaces;
using DTO;

namespace DataLayer
{
    public class DataController : IDataLayer
    {
        private DataProducer _producer;
        private XMLGemNulpunkt NPJ;
        private HentNulpunktXML HentNPJ;
        private XMLGemKalibrering Kalib;
        private IDAQ IDaq;
        private Hent_Kalibrering HentKalib;
        private XML_gem GemMåling;


        public DataController(DataProducer producer)
        {
            _producer = producer;
            NPJ = new XMLGemNulpunkt();
            IDaq = new DAQ();
            HentNPJ = new HentNulpunktXML();
            Kalib = new XMLGemKalibrering();
            HentKalib = new Hent_Kalibrering();
            GemMåling = new XML_gem();
        }

        public void GemMålingIXML(PatientDTO PDTO, MålingDTO MDTO)
        {
            GemMåling.LavXML(MDTO, PDTO);
        }

        public void GemKalibrering(KalibreringDTO KalibDTO)
        {
            Kalib.GemXML1(KalibDTO);
        }

        public void GemNPJ(double Nulpunkt)
        {
            NPJ.GemXMLNulpunkt(Nulpunkt);
        }

        public double hentNPJ()
        {
            return HentNPJ.HentNPJ();
        }

        public KalibreringDTO HentKalibrering()
        {
            return HentKalib.HentKal();
        }

        public void StartProducerTråd()
        {
            _producer.kør = true;
            Thread producerThread = new Thread(_producer.Run);
            producerThread.Start();
        }

        public KalibreringDTO LavKalibrering(int mmHg)
        {
            Hent_Kalibrering hentKalib = new Hent_Kalibrering();
            return hentKalib.HentKal();
        }

        public void StopProducerTråd()
        {
            _producer.kør = false;
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
