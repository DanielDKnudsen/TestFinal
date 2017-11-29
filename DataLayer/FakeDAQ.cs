using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataLayer
{
    public class FakeDAQ : IDAQ
    {
        public MålingDTO CollectNulpunktsListe()
        {
            List<double> liste = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                liste.Add(i);
            }
            MålingDTO mDTO = new MålingDTO();
            mDTO.Data = liste;
            return mDTO;
        }
    }
}
