using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DataLayer
{
    public class DAQ
    {
        private NI_DAQVoltage _blodmåler;
        public DAQ()
        {
            _blodmåler = new NI_DAQVoltage();
            _blodmåler.rangeMaximumVolt = 4;
            _blodmåler.rangeMinimumVolt = -4;
            _blodmåler.sampleRateInHz = 1000;
            _blodmåler.samplesPerChannel = 5000;
        }
        public MålingDTO CollectNulpunktsListe()
        {
            _blodmåler.getVoltageSeqBlocking();
            MålingDTO målingDto = new MålingDTO();
            målingDto.Data = _blodmåler.currentVoltageSeq;
            return målingDto;
        }

        public MålingDTO StartMåling()
        {
            _blodmåler.getVoltageSeqBlocking();
            MålingDTO test = new MålingDTO();
            test.Data = _blodmåler.currentVoltageSeq;
            return test;
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
