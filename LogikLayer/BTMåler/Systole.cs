using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using LogikLayer.BTMåler;
using ObserverPatternVol2;

namespace LogikLayer
{
    public class Systole
    {
        public AutoResetEvent objSys = new AutoResetEvent(false);
        public double Grænseværdi { get; set; }
        private List<double> _data;
        private MålingContainer _målingContainer;
        private Puls P;
        private List<int> _TickList;
        

        public Systole(List<double> convertedList, MålingContainer målingContainer, List<int> TickList)
        {
            _data = convertedList;
            _målingContainer = målingContainer;
            _TickList = TickList;
        }

        public void BeregnSys()
        {
            objSys.WaitOne();

            if (_data.Count > 5000)
            {
                double TimeElapsed = (_TickList[_TickList.Count - 1] - _TickList[0]);
                double forhold = TimeElapsed / 5000;

                List<double> SS = new List<double>();
                Grænseværdi = _data.Max() * 0.8;
                List<double> Systoler = new List<double>();
                List<double> tid = new List<double>();

                for (int i = 0; i < _data.Count-12; i++)
                {
                    if (_data[i] > Grænseværdi)
                    {
                        SS.Add(_data[i]);

                        if (_data[i + 10] < Grænseværdi)
                        {
                            i = i+10 ;
                            Systoler.Add(SS.Max());
                            tid.Add(((i-(SS.Count/2))*forhold)/1000);
                            SS.Clear();
                        }
                    }
                }
                P = new Puls(tid, _målingContainer);
                P.PulsBeregning();
                _målingContainer.setSys(Convert.ToInt32(Systoler[Systoler.Count - 1]));
            }
        }
    }
}
