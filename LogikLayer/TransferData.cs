using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace LogikLayer
{
    public class TransferData : SubjectTransferData
    {
        public MålingDTO mDTO { get; set; }

        public void Done()
        {

            if (mDTO.Dia != 0 && mDTO.MiddelBT != 0 && mDTO.Puls != 0 && mDTO.Sys != 0)
            {
                Notify(mDTO);
            }

            
        }



        
    }
}
