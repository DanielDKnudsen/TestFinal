using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace PresentationLayer
{
    public partial class KalibreringGraf : Form
    {
        private List<double> _list;
        private KalibreringDTO _kDTO;

        public KalibreringGraf(KalibreringDTO kDTO)
        {
            InitializeComponent();
            _kDTO = kDTO;
            _list = kDTO.KalibrerDoubles;
            tegnGraf();
        }

        private void tegnGraf()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    this.chart1.Series["Slope"].Points.AddXY(i,i* _kDTO.slope);

            //    if (i == 10)
            //    {
            //        this.chart1.Series["Kalib"].Points.AddXY(i, _list[0]);
            //        this.chart1.Series["Kalib"].Points.AddXY(i, _list[3]);
            //    }
            //    if (i == 50)
            //    {
            //        this.chart1.Series["Kalib"].Points.AddXY(i, _list[1]);
            //        this.chart1.Series["Kalib"].Points.AddXY(i, _list[4]);
            //    }
            //    if (i == 100)
            //    {
            //        this.chart1.Series["Kalib"].Points.AddXY(i, _list[2]);
            //        this.chart1.Series["Kalib"].Points.AddXY(i, _list[5]);
            //    }
            //}
            this.chart1.Series["Kalib"].Points.AddXY(10, _list[0]);
            this.chart1.Series["Kalib"].Points.AddXY(10, _list[3]);
            this.chart1.Series["Kalib"].Points.AddXY(50, _list[1]);
            this.chart1.Series["Kalib"].Points.AddXY(50, _list[4]);
            this.chart1.Series["Kalib"].Points.AddXY(100, _list[2]);
            this.chart1.Series["Kalib"].Points.AddXY(100, _list[5]);

            VISKALIB_LABEL.Text = "Hældningen er : " + Convert.ToString(_kDTO.slope);
            //chart1.ChartAreas["Slope"].AxisY.Maximum = 100;
            //chart1.ChartAreas["Slope"].AxisX.Maximum = 100;
            //chart1.ChartAreas["Kalib"].AxisY.Maximum = 100;
            //chart1.ChartAreas["Kalib"].AxisX.Maximum = 100;

        }
    }
}
