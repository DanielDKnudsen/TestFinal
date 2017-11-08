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
            return Convert.ToInt32(systoler.Count / 500) * 60;
        }

    }
}
