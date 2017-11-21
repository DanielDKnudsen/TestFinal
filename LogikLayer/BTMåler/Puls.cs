using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikLayer
{
    public class Puls
    {
        public int PulsBeregning(List<double> systoler)
        {
            double tidIalt = 0;
            for (int i = 0; i < systoler.Count-1; i++)
            {
                tidIalt =+ systoler[i+1] - systoler[i];
            }
            double puls = ((systoler.Count-1) / tidIalt) * 60;
            return Convert.ToInt32(puls);
        }
    }
}
