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
        void StartTråde();
        void SetNPJ();
        string NulpunktStart();
        bool StartKalibrering(int mmHg);
        void setKali(int mmHg);
        bool GetTidfaktor();
        void GemKalibrering(KalibreringDTO KalibDTO);
        void SetFilter(string Filter);
        KalibreringDTO kalibliste();
        void GemAlleMålinger(PatientDTO PDTO);
    }
}
