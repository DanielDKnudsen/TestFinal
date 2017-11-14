using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogikLayer
{
    public class ListerTilLogind
    {
        public List<string> brugernavneSundhed = new List<string>();
        public List<string> brugernavneMed = new List<string>();
        public List<string> KodeordSundhed = new List<string>();
        public List<string> KodeordMed = new List<string>();

        public void LavLister()
        {
            brugernavneSundhed.Add("123");
            brugernavneMed.Add("456");
            KodeordSundhed.Add("123");
            KodeordMed.Add("456");
        }
    }
}
