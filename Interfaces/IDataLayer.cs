using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface IDataLayer
    {
        void GemPatient(PatientDTO PDTO);
        MålingDTO startMåling();
    }
}
