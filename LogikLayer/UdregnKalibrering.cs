using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Math.Transforms;
using Accord.Statistics.Models;
using Accord.MachineLearning;
using Accord.Statistics.Models.Regression.Linear;
using DTO;
using Interfaces;

namespace LogikLayer
{
    public class UdregnKalibrering
    {
        private double[] kalibreringer;
        private double[] output;
        private double slope;

        public UdregnKalibrering()
        {

        }

        public void GetKalibrering(KalibreringDTO kDTO)
        {
            double[] kalibreringer = new double[] { (kDTO.KalibrerDoubles[0] + kDTO.KalibrerDoubles[3]) / 2,  (kDTO.KalibrerDoubles[1] + kDTO.KalibrerDoubles[4]) / 2, (kDTO.KalibrerDoubles[2] + kDTO.KalibrerDoubles[5]) / 2};
            double[] output = new double[] { 10, 50, 100 };

        }

        public double Slope()
        {

            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
            SimpleLinearRegression regression = ols.Learn(kalibreringer, output);
            slope = regression.Slope;
            return slope;
        }
    }
}
