using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using DTO;

namespace DataLayer
{
    public class XML_gem
    {

        private void LavXML(MålingDTO mdto, PatientDTO pdto)
        {
            string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\" + pdto.Fornavn + pdto.Efternavn;

            byte[] data = new byte[mdto.Data.Count];
            string dataString = Convert.ToBase64String(data);

            if (File.Exists(filNavn))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filNavn + ".xml");
                XmlNode Måling = doc.CreateElement("Måling");
                XmlNode Målingstidspunkt = doc.CreateElement("Målingstidspunkt");
                Målingstidspunkt.InnerText = mdto.Tid.ToString();
                Måling.AppendChild(Målingstidspunkt);
                XmlNode Målingsdata = doc.CreateElement("Målingsdata");
                Målingsdata.InnerText = dataString;
                Måling.AppendChild(Målingsdata);
                doc.DocumentElement.AppendChild(Måling);
                doc.Save(filNavn);
            }

            else
            {
                XmlTextWriter xWriter = new XmlTextWriter(filNavn, Encoding.UTF8);
                xWriter.Formatting = Formatting.Indented;
                xWriter.WriteStartElement(pdto.Fornavn + pdto.Efternavn);
                xWriter.WriteStartElement("Måling");
                xWriter.WriteStartElement("Målingstidspunkt");
                xWriter.WriteString(mdto.Tid.ToString());
                xWriter.WriteEndElement();
                xWriter.WriteStartElement("Målingsdata");
                xWriter.WriteString(dataString);
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.WriteEndElement();
                xWriter.Close();
            }


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
