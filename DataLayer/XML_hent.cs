using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DataLayer
{
    public class XML_hent
    {
        string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\" + pdto.Fornavn + pdto.Efternavn;

        byte[] data = new byte[mdto.Data.Count];
        string dataString = Convert.ToBase64String(data);

        public void HentMåling(string )
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filNavn + ".xml");
            doc.SelectNodes()
        }
    }
}
