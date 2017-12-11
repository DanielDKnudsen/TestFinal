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
        private MiddelBT mBT;
        private Diastole DS;

        public BTMålerController(MålingContainer Målingcontainer)
        {
            _målingContainer = Målingcontainer;
            PatientMåles = false;
        }

        public void StartTråde(List<double> ConvertedList, List<int> TickList)
        {
            SD = new Systole(ConvertedList, _målingContainer, TickList);
            Thread SysThread = new Thread(SD.BeregnSys);
            SysThread.Start();
            SD.objSys.Set();

            mBT = new MiddelBT(ConvertedList, _målingContainer);
            Thread MidThread = new Thread(mBT.UdregnMiddelBT);
            MidThread.Start();
            mBT.objBT.Set();

            DS = new Diastole(ConvertedList, _målingContainer);
            DS.BeregnDiastole();
            
        }
    }
}
