using System;
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

        public Kalibrering(IDataLayer dl)
        {
            DL = dl;
        }

        public bool startKalibrering(int mmHg)
        {
            List<double> Kalib = new List<double>();
            Kalib = DL.LavKalibrering(mmHg);
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
            if (mmHg == 100 && i == 5) { mm2Hg100 = gnms; i = 6; }

            

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
    }
}

