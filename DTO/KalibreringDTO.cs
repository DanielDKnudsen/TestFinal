using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KalibreringDTO
    {
        public List<double> KalibrerDoubles;
        public string Brugernavn { get; set; }
        public double slope { get; set; }
    }
}
