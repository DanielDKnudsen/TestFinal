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
    public class XMLGemKalibrering
    {
        private string filNavnDaniel = @"C:\Users\Daniel\source\repos\TestFinal\Kalibrering.xml";
        private string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\Kalibrering.xml";
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

        private byte[] ConvertToBinary(List<double> data)
        {
            var binformatter = new BinaryFormatter();
            var mStream = new MemoryStream();

            binformatter.Serialize(mStream, data);

            return mStream.ToArray();
        }
    }
}
