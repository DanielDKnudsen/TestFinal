using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace DataLayer
{
    public class DataController : IDataLayer
    {
        public void GemPatient(PatientDTO PDTO)
        {
            
        }

        public List<double> LavKalibrering()
        {
            Hent_Kalibrering hentKalib = new Hent_Kalibrering();
            return hentKalib.LavKalibrering();
        }

        public MålingDTO startMålingPrøve()
        {
            DAQ daq = new DAQ();
            return daq.CollectNulpunktsListe();
            
        }

        public MålingDTO Start()
        {
            DAQ dak = new DAQ();
            return dak.StartMåling();
        }

        
    }
}
