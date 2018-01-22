using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Statistics.Models.Regression.Linear;
using DTO;
using Interfaces;

namespace LogikLayer
{
    public class UdregnKalibrering
    {
        private double slope;

        public double Slope(KalibreringDTO kDTO)
        {
            double[] kalibreringer = new double[] { (kDTO.KalibrerDoubles[0] + kDTO.KalibrerDoubles[3]) / 2, (kDTO.KalibrerDoubles[1] + kDTO.KalibrerDoubles[4]) / 2, (kDTO.KalibrerDoubles[2] + kDTO.KalibrerDoubles[5]) / 2 };
      
            double[] output = new double[] { 10, 50, 100 };

            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();
            SimpleLinearRegression regression = ols.Learn(kalibreringer, output);
            slope = regression.Slope;
            return slope;
        }
    }
}
