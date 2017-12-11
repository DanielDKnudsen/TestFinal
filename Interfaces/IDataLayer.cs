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
        MålingDTO startMålingPrøve();
        MålingDTO Start();
        List<double> LavKalibrering(int mmHg);
        void GemKalibrering(KalibreringDTO KalibDTO);
        void StartProducerTråd();
        void GemNPJ(double Nulpunkt);
        double hentNPJ();
        List<double> HentKalibrering();
    }
}
