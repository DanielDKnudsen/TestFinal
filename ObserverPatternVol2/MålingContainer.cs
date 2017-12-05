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
        public MålingDTO _mDTO = new MålingDTO();
        private int index;

        public void setSys(int sys)
        {
            _mDTO.Sys = sys;
            index++;
            Done(_mDTO);
        }

        public void setDia(int dia)
        {
            _mDTO.Dia = dia;
            index++;
            Done(_mDTO);
        }

        public void setBT(int bt)
        {
            _mDTO.MiddelBT = bt;
            index++;
            Done(_mDTO);
        }

        public void setPuls(int puls)
        {
            _mDTO.Puls = puls;
            index++;
            Done(_mDTO);
        }


        public void Done(MålingDTO m)
        {
            if (index == 4)
            {
                Notify(m);
                index = 0;
            }
        }
    }
}
