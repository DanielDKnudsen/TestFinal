using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace LogikLayer
{
    public class Logind
    {
        private List<string> brugernavneSundhed = new List<string>();
        private List<string> brugernavneMed = new List<string>();
        private List<string> KodeordSundhed = new List<string>();
        private List<string> KodeordMed = new List<string>();

        private List<string> _brugerinformation = new List<string>();
        public Logind()
        {
            LavLister();
        }

        public int CheckValues(LogindDTO LDTO)
        {
            if (LDTO.IsSundhed)
            {
                for (int i = 0; i < brugernavneSundhed.Count; i++)
                {
                    if (brugernavneSundhed[i] == LDTO.Brugernavn)
                    {
                        if (KodeordSundhed[i] == LDTO.Kodeord)
                        {
                            return 1;
                        }
                        else return 0;
                    }
                }
            }
            if (!LDTO.IsSundhed)
            {
                for (int i = 0; i < brugernavneMed.Count; i++)
                {
                    if (brugernavneMed[i] == LDTO.Brugernavn)
                    {
                        if (KodeordMed[i] == LDTO.Kodeord)
                        {
                            return 2;
                        }
                        else return 0;
                    }
                }
            }
            return 0;
        }

        public void RequestLogOut()
        {
            
        }

        private void LavLister()
        {
            brugernavneSundhed.Add("123");
            brugernavneMed.Add("456");
            KodeordSundhed.Add("123");
            KodeordMed.Add("456");
        }
    }
}
