﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace LogikLayer
{
    public class Kalibrering
    {
        private IDataLayer DL;
        private double gnms;
        private double mm1Hg10;
        private double mm1Hg50;
        private double mm1Hg100;
        private double mm2Hg10;
        private double mm2Hg50;
        private double mm2Hg100;
        private int i = 0;
        public KalibreringDTO KDTO;
        public bool Gem;
        private List<double> Kalib = new List<double>();


        public Kalibrering(IDataLayer dl)
        {
            Gem = false;
            DL = dl;
            KDTO = new KalibreringDTO();
            mm1Hg10 = 0;
            mm1Hg50 = 0;
            mm1Hg100 = 0;
            mm2Hg10 = 0;
            mm2Hg50 = 0;
            mm2Hg100 = 0;
        }

        public bool startKalibrering(int mmHg)
        {
            Kalib = DL.startMålingPrøve().Data;
            
            gnms = Kalib.Sum() / Kalib.Count;

            if (gnms < mmHg + 0.5 && gnms > mmHg - 0.5)
            {
                return true;
            }
            else
                return false;
        }

        public void setKali(int mmHg)
        {
            if (mmHg == 10 && i == 0) { mm1Hg10 = gnms; i = 1; }
            if (mmHg == 50 && i == 1) { mm1Hg50 = gnms; i = 2; }
            if (mmHg == 100 && i == 2) { mm1Hg100 = gnms; i = 3; }
            if (mmHg == 10 && i == 3) { mm2Hg10 = gnms; i = 4; }
            if (mmHg == 50 && i == 4) { mm2Hg50 = gnms; i = 5; }
            if (mmHg == 100 && i == 5) { mm2Hg100 = gnms; i = 6; LavGemDTO(); }
        }

        public List<double> TegnKalibGraf()
        {
            List<double> KalibGraf = new List<double>();
            if (i == 6)
            {
                KalibGraf.Add(mm1Hg10);
                KalibGraf.Add(mm1Hg50);
                KalibGraf.Add(mm1Hg100);
                KalibGraf.Add(mm2Hg10);
                KalibGraf.Add(mm2Hg50);
                KalibGraf.Add(mm2Hg100);
            }
            return KalibGraf;

        }
        public void LavGemDTO()
        {
            
            if (i == 6)
            {
                KDTO.KalibrerDoubles = new List<double>();
                KDTO.KalibrerDoubles.Add(mm1Hg10);
                KDTO.KalibrerDoubles.Add(mm1Hg50);
                KDTO.KalibrerDoubles.Add(mm1Hg100);
                KDTO.KalibrerDoubles.Add(mm2Hg10);
                KDTO.KalibrerDoubles.Add(mm2Hg50);
                KDTO.KalibrerDoubles.Add(mm2Hg100);
                Gem = true;
            }
           
        }
    }
}

