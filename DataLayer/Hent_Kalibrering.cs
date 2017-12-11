using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DTO;

namespace DataLayer
{
    public class Hent_Kalibrering
    {
        private string filNavnDaniel = @"C:\Users\Daniel\source\repos\TestFinal\";
        private string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\";
        private KalibreringDTO kDTO;

        public KalibreringDTO HentKal()
        {
            kDTO = new KalibreringDTO();
            kDTO.KalibrerDoubles = new List<double>();

            XmlDocument doc = new XmlDocument();
            doc.Load(filNavnDaniel + "Kalibrering" + ".xml");
            XmlNodeList Node = doc.GetElementsByTagName("Måling");

            for (int i = 0; i < Node.Count; i++)
            {
                kDTO.KalibrerDoubles.Add(Convert.ToDouble(Node[i].InnerText));
            }

            XmlNodeList NodeSlope = doc.GetElementsByTagName("Slope");

            for (int i = 0; i < 1; i++)
            {
                kDTO.slope = Convert.ToDouble(NodeSlope[0].InnerText);
            }

            return kDTO;
        }
    }
}
