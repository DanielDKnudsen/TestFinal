using System;
using System.Collections.Generic;
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

        public Systole(List<double> convertedList, MålingContainer målingContainer)
        {
            _data = convertedList;
            _målingContainer = målingContainer;
        }

        public void BeregnSys()
        {
            objSys.WaitOne();

            if (_data.Count > 5000)
            {
                List<double> SS = new List<double>();
                Grænseværdi = _data.Max() * 0.7;
                List<double> Systoler = new List<double>();
                List<double> tid = new List<double>();

                for (int i = 0; i < _data.Count-22; i++)
                {
                    if (_data[i] > Grænseværdi)
                    {
                        SS.Add(_data[i]);

                        if (_data[i + 10] < Grænseværdi)
                        {
                            i = i+10 ;
                            Systoler.Add(SS.Max());
                            tid.Add((i-(SS.Count*0.5)) * 0.001);
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
