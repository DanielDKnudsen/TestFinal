using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Interfaces;
using System.Windows.Forms.DataVisualization.Charting;
using ObserverPatternVol2;


namespace Projekt_v1._1
{
    public partial class UIPatient : Form, IDataObserver, IFilterObserver, IMålingObserver
    {
        private ILogikLayer LL;
        private bool DigFilter;
        private string fortsæt;
        private DataContainer _dct;
        private MålingContainer _målingContainer;
        private int _DiaMax = 0;
        private int _DiaMin = 0;
        private int _SysMax = 0;
        private int _SysMin = 0;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\mikke\Documents\GitHub\TestFinal\Alarm.wav");
        Stopwatch STP =  new Stopwatch();

        public UIPatient(string navn, DateTime tid, ILogikLayer ll, DataContainer DCT, MålingContainer målingContainer, string DiaMax,string DiaMin, string SysMax,string SysMin)
        {
            InitializeComponent();
            UIPatient_LabelPatientNavn.Text = navn;
            UIPatient_LabelDato.Text = tid.ToLongDateString();
            LL = ll;
            _dct = DCT;
            _dct.Attach(this);
            _målingContainer = målingContainer;
            _målingContainer.Attach(this);
            opsætGraf();
            _DiaMax = Convert.ToInt16(DiaMax);
            _DiaMin = Convert.ToInt16(DiaMin);
            _SysMax = Convert.ToInt16(SysMax);
            _SysMin = Convert.ToInt16(SysMin);

        }

        private void opsætGraf()
        {
            BTChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            BTChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            //BTChart.ChartAreas[0].AxisX.Title = "Tid i Sekunder";
            //BTChart.ChartAreas[0].AxisY.Title = "Tryk i mmHg";
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
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Update(filtreretKø)));
            }
            else
            {
                double måling = 0;
                BTChart.Series["BT"].Points.Clear();
                
                for (int i = 0; i < filtreretKø.Count - 1; i++)
                {
                    BTChart.Series["BT"].Points.AddXY(måling,filtreretKø.ElementAt(i));
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
                UIPatient_KnapDigital.ForeColor = Color.Black;
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

        private void UIPatient_Load(object sender, EventArgs e)
        {

        }

        public void UpdateAnalyse(MålingDTO _mdto)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateAnalyse(_mdto)));
            }
            else
            {
                if (STP.ElapsedMilliseconds == 0 || STP.ElapsedMilliseconds >= 10000)
                {
                    Alarm(_mdto);
                }
                
                UIPatient_LabelMID.Text = Convert.ToString(_mdto.MiddelBT);
                UIPatient_LabelPULS.Text = Convert.ToString(_mdto.Puls);
                UIPatient_LabelSysDia.Text = Convert.ToString(_mdto.Sys) + "/" + Convert.ToString(_mdto.Dia);
            }
        }

        public void Alarm(MålingDTO mDTO)
        {
            
            if (mDTO.Sys > _SysMax || mDTO.Sys < _SysMin)
            {
                player.PlayLooping();
                UIPatient_KnapStopAlarm.Enabled = true;
            }
            if (mDTO.Dia > _DiaMax || mDTO.Sys < _DiaMin)
            {
                player.PlayLooping();
                UIPatient_KnapStopAlarm.Enabled = true;
            }
        }

        private void UIPatient_KnapStopAlarm_Click(object sender, EventArgs e)
        {
            StopAlarm();
        }

        private void StopAlarm()
        {
            player.Stop();
            STP.Start();
        }
    }

}