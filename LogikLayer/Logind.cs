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
        public int CheckValues(LogindDTO LDTO)
        {
            ListerTilLogind LTL = new ListerTilLogind();
            LTL.LavLister();

            if (LDTO.IsSundhed)
            {
                for (int i = 0; i < LTL.brugernavneSundhed.Count; i++)
                {
                    if (LTL.brugernavneSundhed[i] == LDTO.Brugernavn)
                    {
                        if (LTL.KodeordSundhed[i] == LDTO.Kodeord)
                        {
                            return 1;
                        }
                        else return 0;
                    }
                }
            }
            if (!LDTO.IsSundhed)
            {
                for (int i = 0; i < LTL.brugernavneMed.Count; i++)
                {
                    if (LTL.brugernavneMed[i] == LDTO.Brugernavn)
                    {
                        if (LTL.KodeordMed[i] == LDTO.Kodeord)
                        {
                            return 2;
                        }
                        else return 0;
                    }
                }
            }
            return 0;
        }
    }
}
