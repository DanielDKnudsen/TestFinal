﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class KalibreringGraf : Form
    {
        private List<double> _list;
        public KalibreringGraf(List<double> list)
        {
            _list = list;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Kalib"].Points.AddXY(_list);
        }
    }
}
