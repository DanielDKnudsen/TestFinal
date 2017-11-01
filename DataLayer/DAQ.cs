using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAQ
    {
        private NI_DAQVoltage _ekgmåler;
        public DAQ()
        {
            _ekgmåler = new NI_DAQVoltage();
            _ekgmåler.rangeMaximumVolt = 3;
            _ekgmåler.rangeMinimumVolt = -2;
            _ekgmåler.sampleRateInHz = 500;
            _ekgmåler.samplesPerChannel = 5000;
        }
        public Måling_DTO StartDAQ(Måling_DTO måling)
        {
            _ekgmåler.getVoltageSeqBlocking();
            List<double> EKGMålinger = _ekgmåler.currentVoltageSeq;
            måling.AddEKGData(EKGMålinger);
            return måling;
        }


    }
}
