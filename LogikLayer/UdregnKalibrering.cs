using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math.Transforms;
using Accord.Statistics.Models;
using Accord.MachineLearning;
using Accord.Statistics.Models.Regression.Linear;
using Interfaces;

namespace LogikLayer
{
    public class UdregnKalibrering
    {
        private double[] kalibreringer;
        private double[] output;

        public UdregnKalibrering()
        {
            var untzuntzunztz = new OrdinaryLeastSquares();
        }

        public void GetKalibrering(List<double> kalibList)
        {
            double[] kalibreringer = new double[] { (kalibList[0] + kalibList[3]) / 2,  (kalibList[1] + kalibList[4]) / 2, (kalibList[2] + kalibList[5]) / 2};
            double[] output = new double[] { 10, 50, 100 };
        }

        public void Slope()
        {
            
        }
    }
}
