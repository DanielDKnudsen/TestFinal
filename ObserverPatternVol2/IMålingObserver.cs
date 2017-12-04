using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace ObserverPatternVol2
{
    public interface IMålingObserver
    {
        void Update(MålingDTO _mdto);
    }
}
