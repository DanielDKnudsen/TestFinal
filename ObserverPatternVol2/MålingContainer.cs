using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ObserverPatternVol2
{
    public class MålingContainer : MålingContainerSubject
    {
        public void Done(MålingDTO _mdto)
        {
            Notify(_mdto);

        }
    }
}
