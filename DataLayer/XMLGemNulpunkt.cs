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
    public class XMLGemNulpunkt
    {
        private string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\Nulpunkt.xml";
        public void GemXMLNulpunkt(double Nulpunkt)
        {
            string nulpunkt = Convert.ToString(Nulpunkt);
            XmlTextWriter xWriter = new XmlTextWriter(filNavn, Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartElement("Nulpunkt");
            xWriter.WriteStartElement("Dato");
            xWriter.WriteString(DateTime.Now.ToString());
            xWriter.WriteString(nulpunkt);
            xWriter.WriteEndElement();
            xWriter.WriteEndElement();
            xWriter.Close();
        }
    }
}