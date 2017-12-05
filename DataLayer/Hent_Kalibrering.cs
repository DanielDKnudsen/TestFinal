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
        private string filNavnDaniel = @"C:\Users\Daniel\source\repos\TestFinal";
        private string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\";

        public List<double> HentKal()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filNavnDaniel + "Kalibrering" + ".xml");

            byte[] KalibBytes = Convert.FromBase64String(Convert.ToString(doc.DocumentElement.SelectSingleNode("/Kalibrering/Dato/Brugernavn/Kalibreringsdata")));



            return ConvertToList(KalibBytes);
        }

        public void GemXML(KalibreringDTO kalibreringDTO)
        {
            byte[] data = new byte[kalibreringDTO.KalibrerDoubles.Count];
            string dataString = Convert.ToBase64String(data);

            XmlTextWriter xWriter = new XmlTextWriter(filNavn, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartElement("Kalibrering");
            xWriter.WriteStartElement("Dato");
            xWriter.WriteString(DateTime.Now.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Brugernavn");
            xWriter.WriteString(kalibreringDTO.Brugernavn);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Kalibreringsdata");
            xWriter.WriteString(dataString);
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.Close();
        }

        private List<double> ConvertToList(byte[] Byte)
        {
            List<double> list = new List<double>();
            foreach (var item in Byte)       
            {
                list.Add(item);
            }
            return list;
        }
    }
}
