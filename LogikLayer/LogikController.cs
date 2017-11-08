using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace LogikLayer
{
    public class LogikController : ILogikLayer
    {
        private IDataLayer DL;

        public LogikController(IDataLayer dl)
        {
            DL = dl;
        }

        public int RequestLogind(LogindDTO LDTO)
        {
            Logind Log = new Logind();
            return Log.CheckValues(LDTO);
        }

        public int StartNPJ()
        {
            Nulpunktsjustering NP = new Nulpunktsjustering(DL);
            
        }

        public void StartMåling()
        {
            Systole_Diastole SD = new Systole_Diastole();
            List<double> Systoler = new List<double>();
            Systoler = SD.BeregnSys(DL.startMåling().Data);

            Puls pKlasse = new Puls();
            int Puls = pKlasse.PulsBeregning(Systoler);



        }
       

        public void GemPatient(PatientDTO PDTO)
        {
            DL.GemPatient(PDTO);
        }
       
    }
}
