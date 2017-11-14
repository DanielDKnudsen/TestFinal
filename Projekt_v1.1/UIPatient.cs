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

namespace Projekt_v1._1
{
    public partial class UIPatient : Form
    {

        public UIPatient(string navn, MålingDTO dto, DateTime tid)
        {
            InitializeComponent();
            UIPatient_LabelPatientNavn.Text = navn;
            UIPatient_LabelDato.Text = tid.ToLongDateString();
            TegnGraf(dto);

        }

        private void UIPatient_LabelPatientNavn_Click(object sender, EventArgs e)
        {
            

        }

        private void UIPatient_KnapNul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Der foretages nu nulpunktsjustering");
        }

        public void TegnGraf(MålingDTO dto)
        {
            double t = 0.000; //Tid på x-aksen
            for (int i = 0; i < 1000; i++)  //For-løkke som tegner grafen med tiden på x-aksen og EKG-målinger på y-aksen. 
            {
                BTChart.Series["EKG"].Points.AddXY(t, dto.Data[i]);
                t += 0.002; //Tiden øges med 0.002, da der måles med en frekvens på 500Hz. 
            }
        }

        private void UIPatient_LabelDato_Click(object sender, EventArgs e)
        {

        }
    }
}
