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
using Interfaces;

namespace Projekt_v1._1
{
    public partial class UIPatient : Form, IFilterObserver, IDataObserver
    {
        private ILogikLayer LL;
        private bool DigFilter;

        public UIPatient(string navn, MålingDTO dto, DateTime tid, ILogikLayer ll)
        {
            InitializeComponent();
            UIPatient_LabelPatientNavn.Text = navn;
            UIPatient_LabelDato.Text = tid.ToLongDateString();
            LL = ll;
        }

        private void UIPatient_LabelPatientNavn_Click(object sender, EventArgs e)
        {
        }

        private void UIPatient_KnapNul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der foretages nu nulpunktsjustering");
        }

        public void UpdateData(MålingDTO mDTO)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateData(mDTO)));
            }
            else
            {
                UIPatient_LabelMID.Text = mDTO.MiddelBT.ToString();
                UIPatient_LabelPULS.Text = mDTO.Puls.ToString();
                UIPatient_LabelSysDia.Text = mDTO.Sys.ToString() + "/" + mDTO.Dia.ToString();
            }
        }

        public void UpdateChart(Queue<double> filtreretKø)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateChart(filtreretKø)));
            }
            else
            {
                int måling = 0;
                BTChart.Series["BT"].Points.Clear();
                for (int i = 0; i < filtreretKø.Count; i++)
                {
                    BTChart.Series[i].Points.AddXY(måling, filtreretKø.ElementAt(i));
                    måling++;
                }
            }
        }

        private void UIPatient_LabelDato_Click(object sender, EventArgs e)
        {
        }

        private void UIPatient_KnapDigital_Click(object sender, EventArgs e)
        {
            string filter = "";
            if (DigFilter)
            {
                DigFilter = false;
                filter = "RawFilter";
                UIPatient_KnapDigital.BackColor = Color.Black;
            }

            if (!DigFilter)
            {
                DigFilter = true;
                filter = "DigFilter";
                UIPatient_KnapDigital.BackColor = Color.Yellow;
            }
            LL.SetFilter(filter);
        }

        private void UIPatient_KnapStart_Click(object sender, EventArgs e)
        {

        }
    }
}