using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternVol2;

namespace LogikLayer.BTMåler
{
    public class Diastole
    {
        private MålingContainer _målingContainer;
        private List<double> _convertedlist = new List<double>();

        public Diastole(List<double> convertedList, MålingContainer målingContainer)
        {
            _convertedlist = convertedList;
            _målingContainer = målingContainer;
        }

        public void BeregnDiastole()
        {
            _målingContainer.setDia(Convert.ToInt32(_convertedlist.Min() / (5 * 0.000005 * 736.294)));
        }
    }
}
