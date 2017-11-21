using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public LogikController(IDataLayer dl)
        {
            DL = dl;
            kalib = new Kalibrering(DL);

        }

        public void GemKalibrering(KalibreringDTO KalibDTO)
        {
            DL.GemKalibrering(KalibDTO);
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

        //public int StartNPJ()
        //{
        //    Nulpunktsjustering NP = new Nulpunktsjustering(DL);
            
        //}




        public MålingDTO StartMåling()
        {
            //Systole_Diastole SD = new Systole_Diastole();
            //List<double> Systoler = new List<double>();
            //Systoler = SD.BeregnSys(DL.startMåling().Data);

            //Puls pKlasse = new Puls();
            //int Puls = pKlasse.PulsBeregning(Systoler);

            MålingDTO dto = new MålingDTO();

            dto = DL.Start();

            return dto;



        }

        public string StartNPJ()
        {
            throw new NotImplementedException();
        }


        public void GemPatient(PatientDTO PDTO)
        {
            DL.GemPatient(PDTO);
        }
       
    }
}
