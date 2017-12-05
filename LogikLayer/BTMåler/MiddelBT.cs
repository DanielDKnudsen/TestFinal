using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ObserverPatternVol2;

namespace LogikLayer.BTMåler
{
    public class MiddelBT
    {
        public AutoResetEvent objBT = new AutoResetEvent(false);
        private List<double> _convertedlist;
        private static MålingContainer _målingContainer;

        public MiddelBT(List<double> convertedList, MålingContainer målingContainer)
        {
            _convertedlist = convertedList;
            _målingContainer = målingContainer;
        }
        public void UdregnMiddelBT()
        {
            objBT.WaitOne();
            _målingContainer.setBT(Convert.ToInt32(_convertedlist.Average()));
        }
    }
}
