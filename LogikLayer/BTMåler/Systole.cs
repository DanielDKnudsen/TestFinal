using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DTO;
using LogikLayer.BTMåler;

namespace LogikLayer
{
    public class Systole
    {
        public AutoResetEvent objSys = new AutoResetEvent(false);
        public double Grænseværdi { get; set; }
        private List<double> _data;

        public Systole(List<double> convertedList)
        {
            _data = convertedList;
        }

        public void BeregnSys()
        {
            objSys.WaitOne();

            if (_data.Count > 5000)
            {
                Grænseværdi = _data.Max() * 0.8;
                List<double> Systoler = new List<double>();
                double s = 0;

                for (int i = 2; i < _data.Count-2; i++)
                {
                    if (_data[i] > Grænseværdi && _data[i + 1] < _data[i] && _data[i + 1] < Grænseværdi)
                    {
                       Systoler.Add(s);
                    }
                    s += 0.001;
                }
                Puls p = new Puls();
                p.PulsBeregning(Systoler);
            }
        }
    }
}
