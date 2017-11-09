using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DTO;

namespace DataLayer
{
    public class XML_gem
    {

        private void LavXML(MålingDTO dto)
        {
            XmlSerializer sr = new XmlSerializer(dto.GetType());
            TextWriter writer = new StreamWriter(Convert.ToString(dto.Tid));
            sr.Serialize(writer, dto);
            writer.Close();
        }
    }
}
