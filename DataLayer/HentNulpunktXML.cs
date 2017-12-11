using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataLayer
{
    public class HentNulpunktXML
    {
        public double HentNPJ()
        {
            string filNavnDaniel = @"C:\Users\Daniel\source\repos\TestFinal";
            string filNavn = @"C:\Users\mikke\Documents\GitHub\TestFinal\";

            XmlDocument doc = new XmlDocument();
            doc.Load(filNavnDaniel + "Nulpunkt" + ".xml");
            XmlNode node = doc.DocumentElement.SelectSingleNode("Nulpunkt.xml");
            string værdi = node.InnerText;

            return Convert.ToDouble(værdi);
        }
    }
}
