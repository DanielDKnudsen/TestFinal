using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MålingDTO
    {
        public long Puls { get; set; }
        public int MiddelBT { get; set; }
        public int Dia { get; set; }
        public int Sys { get; set; }
        public List<double> Data { get; set; }
        public int Samples { get; set; }
        public DateTime Tid { get; set; }

    }
}
