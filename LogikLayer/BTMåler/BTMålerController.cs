using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using System.Threading;


namespace LogikLayer.BTMåler
{
    class BTMålerController
    {
        public bool PatientMåles { get; set; }
        private IDataLayer IdataLayer;
        private Systole SD;

        public BTMålerController(IDataLayer Idata)
        {
            PatientMåles = false;
            IdataLayer = Idata;
        }

        public void StartMålingAsync(IPresentationLayer uiPatient)
        {
            PatientDTO patient = new PatientDTO();
            IdataLayer.startMålingPrøve();
        }

        public void StartTråde(List<double> ConvertedList)
        {
            Systole SD = new Systole(ConvertedList);
            Thread SysThread = new Thread(SD.BeregnSys);
            SysThread.Start();
            SD.objSys.Set();

            MiddelBT mBT = new MiddelBT(ConvertedList);
            Thread MidThread = new Thread(mBT.UdregnMiddelBT);
            MidThread.Start();
            mBT.objBT.Set();

            SysThread.Join(1000);
            MidThread.Join(1000);
        }
    }
}
