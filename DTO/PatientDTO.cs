using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientDTO
    {
        public string CPR { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public DateTime IndlæggelsesDato { get; set; }
        public int Stue { get; set; }
        public int SysMinimum { get; set; }
        public int SysMaximum { get; set; }
        public int DiaMinimum { get; set; }
        public int DiaMaximum { get; set; }
    }
}
