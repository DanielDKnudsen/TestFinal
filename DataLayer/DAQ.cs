using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST2Prj2LibNI_DAQ;

namespace DataLayer
{
    public class DAQ
    {
        private NI_DAQVoltage _ekgmåler;
        private List<double> _nulpunktsjusteringer;
        public DAQ()
        {
            _ekgmåler = new NI_DAQVoltage();
            _ekgmåler.rangeMaximumVolt = 3;
            _ekgmåler.rangeMinimumVolt = -2;
            _ekgmåler.sampleRateInHz = 500;
            _ekgmåler.samplesPerChannel = 5000;
        }
        public List<double> CollectNulpunktsListe()
        {
            _ekgmåler.getVoltageSeqBlocking();
            _nulpunktsjusteringer = _ekgmåler.currentVoltageSeq;
            return _nulpunktsjusteringer;
        }


    }


    //private NI_DAQVoltage _ekgmåler;
    //public List<double> Nulpunktsjusteringer;
    //public DAQ()
    //{
    //_ekgmåler = new NI_DAQVoltage();
    //_ekgmåler.rangeMaximumVolt = 3;
    //_ekgmåler.rangeMinimumVolt = -2;
    //_ekgmåler.sampleRateInHz = 500;
    //_ekgmåler.samplesPerChannel = 5000;
    //}

    //public List<double> StartDAQ()
    //{
    //_ekgmåler.getVoltageSeqBlocking();
    //Nulpunktsjusteringer = _ekgmåler.currentVoltageSeq;
    //return
    //}
}
