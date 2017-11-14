using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface ILogikLayer
    {
        int RequestLogind(LogindDTO LDTO);
        void GemPatient(PatientDTO PDTO);

        MålingDTO StartMåling();

        string StartNPJ();
    }
}
