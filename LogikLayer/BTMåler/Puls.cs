using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternVol2;

namespace LogikLayer
{
    public class Puls
    {
        private List<double> systoler = new List<double>();
        private MålingContainer _målingContainer;

        public Puls(List<double> convertedList, MålingContainer målingContainer)
        {
            systoler = convertedList;
            _målingContainer = målingContainer;
        }

        public void PulsBeregning()
        {
            double tidIalt = 0;
            tidIalt = (systoler[systoler.Count-1] - systoler[0])/1000;
            double puls = ((systoler.Count-1) / tidIalt) * 60;
            _målingContainer.setPuls(Convert.ToInt32(puls));
        }
    }
}

