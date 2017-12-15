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
            Random r1 = new Random();
            List<double> liste = new List<double>();
            for (int i = 0; i < 50; i++)
            {
                liste.Add(i);
            }
            MålingDTO mDTO = new MålingDTO();
            mDTO.Data = liste;
            return mDTO;
        }
    }
}
