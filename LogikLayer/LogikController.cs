﻿using System;
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
        private Kalibrering kalib;
        private Consumer _consumer;
        private Nulpunktsjustering NPJ;
        private Filter _filter;
        private DataContainer _dct;
        private bool tidFaktor;
        private List<double> HeleMålingen = new List<double>();
       

        public LogikController(IDataLayer dl, Consumer consumer,DataContainer DCT, Kalibrering Kalib)
        {
            DL = dl;
            _consumer = consumer;
            _dct = DCT;
            NPJ = new Nulpunktsjustering(DL);
            _filter = new Filter(new RawFilter(), _dct);
            kalib = Kalib;
            HentKalibrering();
        }

        //Hent måling fra consumer-klassen:
        public void MålingTilDB()
        {
            List<double> halvtredsMålinger = new List<double>();
            halvtredsMålinger = _consumer.SendTilLogikLag();

            foreach (var item in halvtredsMålinger)
            {
                HeleMålingen.Add(item);
            }
        }

        public void HentKalibrering()
        {
            KalibreringDTO kDTO = new KalibreringDTO();
            kDTO = DL.HentKalibrering();
            _consumer.GetKalib(kDTO);
        }

        public void GemAlleMålinger(PatientDTO pDTO)
        {
            _consumer.kør = false;
            DL.StopProducerTråd();
            MålingDTO mDTO = new MålingDTO();
            mDTO.Data = HeleMålingen;
            DL.GemMålingIXML(pDTO, mDTO);

        }

        public void SetNPJ()
        {
            DL.GemNPJ(NPJ.NulpunktBeregnet() / (5 * 0.000005 * 736.294));
            _consumer.GetNPJ(NPJ.NulpunktBeregnet());
        }

        public string NulpunktStart()
        {
            NPJ.Nulpunktsjuster();
            return NPJ.FortsætString();
        }

        
        public void StartTråde()
        {
            _consumer.kør = true;
            Thread consumerThread = new Thread(_consumer.Run);
            consumerThread.Start();
            DL.StartProducerTråd();
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
            if (kalib.Gem == true)
            {
                KalibreringDTO KalibDTO = new KalibreringDTO();
                KalibDTO = kalib.KDTO;
                KalibDTO.slope = _consumer.GetSlope(KalibDTO);

                DL.GemKalibrering(KalibDTO);
            }
        }


        public int RequestLogind(LogindDTO LDTO)
        {
            Logind Log = new Logind();
            return Log.CheckValues(LDTO);
        }

        public KalibreringDTO kalibliste()
        {
            KalibreringDTO kdto = new KalibreringDTO();
            kdto = DL.HentKalibrering();

            return kdto;
        }

    }
}
