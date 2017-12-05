using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using System.Threading;
using ObserverPatternVol2;


namespace LogikLayer.BTMåler
{
    public class BTMålerController
    {
        public bool PatientMåles { get; set; }
        private MålingContainer _målingContainer;
        private Systole SD;

        public BTMålerController(MålingContainer Målingcontainer)
        {
            _målingContainer = Målingcontainer;
            PatientMåles = false;
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
