﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace LogikLayer
{
    public class Systole_Diastole
    {
        public double Grænseværdi { get; set; }
        private List<double> _data;
        public List<double> BeregnSys(List<double> data)
        {
            foreach (var item in data)
            {
                _data.Add(item);
            }

            if (_data.Count > 5000)
            {
                Grænseværdi = _data.Max() * 0.8;
                List<double> Systoler = new List<double>();
                double s = 0;

                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] > Grænseværdi && data[i + 1] < data[i] && data[i + 1] < Grænseværdi)
                    {
                       Systoler.Add(s);
                    }
                    s += 0.02;
                }
                _data.Clear();
                return Systoler;
            }
        }
    }
}
