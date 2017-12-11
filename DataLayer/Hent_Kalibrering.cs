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
        List<double> Kalibreringsliste = new List<double>();

        public List<double> HentKal()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filNavnDaniel + "Kalibrering" + ".xml");
            XmlNodeList Node = doc.GetElementsByTagName("Måling");

            for (int i = 0; i < Node.Count; i++)
            {
                Kalibreringsliste.Add(Convert.ToDouble(Node[i].InnerText));
            }
            return Kalibreringsliste;
        }

        //public List<double> ConvertFromByteArray(byte[] data)
        //{
        //    double[] darray = new double[data.Length / sizeof(double)];
        //    Buffer.BlockCopy(data, 0, darray, 0, data.Length);
        //    return darray.ToList<double>();
        //}
    }
}
