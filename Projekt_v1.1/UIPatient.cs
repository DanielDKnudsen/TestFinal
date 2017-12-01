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
using ObserverPattern;
using System.Windows.Forms.DataVisualization.Charting;


namespace Projekt_v1._1
{
    public partial class UIPatient : Form, IDataObserver, IFilterObserver
    {
        private ILogikLayer LL;
        private bool DigFilter;
        private string fortsæt;
        private DataContainer _dct;


        public UIPatient(string navn, DateTime tid, ILogikLayer ll, DataContainer DCT)
        {
            InitializeComponent();
            UIPatient_LabelPatientNavn.Text = navn;
            UIPatient_LabelDato.Text = tid.ToLongDateString();
            LL = ll;
            _dct = DCT;
            _dct.Attach(this);
            opsætGraf();
        }

        private void opsætGraf()
        {
            BTChart.ChartAreas[0].AxisX.MajorGrid.Interval = 1;
            BTChart.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
        }

        private void UIPatient_LabelPatientNavn_Click(object sender, EventArgs e)
        {
        }

        private void UIPatient_KnapNul_Click(object sender, EventArgs e)
        {
            NulpunktsGUI();
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

        public void Update(Queue<double> filtreretKø)
        {
            double faktor = 0;

            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Update(filtreretKø)));
            }
            else
            {
                double måling = 0;
                BTChart.Series["BT"].Points.Clear();

                if (LL.GetTidfaktor())
                {
                    faktor = 1;
                    BTChart.ChartAreas[0].RecalculateAxesScale();
                }
                else
                {
                    faktor = 5;
                    BTChart.ChartAreas[0].AxisX.MajorGrid.Interval = 5;
                    BTChart.ChartAreas[0].RecalculateAxesScale();
                }
                for (int i = 0; i < filtreretKø.Count - 1; i++)
                {
                    BTChart.Series["BT"].Points.AddXY(måling/faktor,filtreretKø.ElementAt(i));
                    måling++;
                }
            }
        }

        public void NulpunktsGUI()
        {
            bool NO = true;
            DialogResult foretages = MessageBox.Show("Der foretages nu nulpunktsjustering");

            this.fortsæt = LL.NulpunktStart();
            DialogResult godkendNulpunkt = MessageBox.Show(fortsæt, "Vil du fortsætte?", MessageBoxButtons.YesNo);
            if (godkendNulpunkt == DialogResult.Yes)
            {
                LL.SetNPJ();
            }
            if (godkendNulpunkt == DialogResult.No)
            {
                DialogResult PrøvIgen = MessageBox.Show("Vil du prøve igen?", "Prøv igen?", MessageBoxButtons.YesNo);
                while (NO)
                {
                    if (PrøvIgen == DialogResult.Yes)
                    {
                        NulpunktsGUI();
                        NO = false;
                    }
                    if (PrøvIgen == DialogResult.No)
                    {
                        NO = false;
                    }
                }
            }
            if (NO)
            {
                UIPatient_KnapDigital.Enabled = true;
                UIPatient_KnapStart.Enabled = true;
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
                filter = "RawFilter";
                UIPatient_KnapDigital.BackColor = Color.Black;
            }

            if (DigFilter == false)
            {
                filter = "DigFilter";
                UIPatient_KnapDigital.BackColor = Color.Yellow;
            }
            if (DigFilter == true)
            {
                DigFilter = false;
            }
            else DigFilter = true;


            LL.SetFilter(filter);
        }

        private void UIPatient_KnapStart_Click(object sender, EventArgs e)
        {
            LL.StartTråde();
        }
    }
}