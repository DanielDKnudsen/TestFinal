using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using System.Threading.Tasks;


namespace LogikLayer.BTMåler
{
    class BTMålerController
    {
        public bool PatientMåles { get; set; }
        private IDataLayer IdataLayer;
        private Puls p1;
        private Systole_Diastole SD;

        public BTMålerController(IDataLayer Idata)
        {
            p1 = new Puls();
            SD = new Systole_Diastole();
            PatientMåles = false;
            IdataLayer = Idata;
        }

        public void StartMålingAsync(IPresentationLayer uiPatient)
        {
            PatientDTO patient = new PatientDTO();
            IdataLayer.startMålingPrøve();

            
        }
    }
}
