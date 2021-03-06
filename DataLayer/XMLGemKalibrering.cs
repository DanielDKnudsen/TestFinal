﻿using System;
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
        public void GemXML1(KalibreringDTO kalibreringDTO)
        {

            XmlTextWriter xWriter = new XmlTextWriter(filNavnDaniel, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartElement("Kalibrering");
            xWriter.WriteStartElement("Dato");
            xWriter.WriteString(DateTime.Now.ToString());
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Brugernavn");
            xWriter.WriteString(kalibreringDTO.Brugernavn);
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Kalibreringsdata");
            
            for (int i = 0; i < kalibreringDTO.KalibrerDoubles.Count; i++)
            {
                xWriter.WriteStartElement("Måling");
                xWriter.WriteString(Convert.ToString(kalibreringDTO.KalibrerDoubles[i]));
                xWriter.WriteEndElement();
            }
            xWriter.WriteEndElement();
            xWriter.WriteStartElement("Slope");
            xWriter.WriteString(Convert.ToString(kalibreringDTO.slope));
            xWriter.WriteEndElement();
            xWriter.Close();
        }
    }
}
