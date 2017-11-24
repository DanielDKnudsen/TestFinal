using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogikLayer.BTMåler
{
    public class MiddelBT
    {
        public AutoResetEvent objBT = new AutoResetEvent(false);
        private List<double> _convertedlist;
        public MiddelBT(List<double> convertedList)
        {
            _convertedlist = convertedList;
        }

        public double middelBT;
        public void UdregnMiddelBT()
        {
            objBT.WaitOne();
            middelBT = 0;
            middelBT = _convertedlist.Average();
        }
    }
}
