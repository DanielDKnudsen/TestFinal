using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Interfaces;
using DTO;
using ObserverPatternVol2;

namespace Projekt_v1._1
{
    public partial class UIKontor1 : Form
    {
        private ILogikLayer LL;
        private DataContainer _dct;
        private MålingContainer _målingContainer;
        private bool _farve = false;


        public UIKontor1(ILogikLayer ll,DataContainer DCT, MålingContainer målingContainer)
        {
            InitializeComponent();
            LL = ll;
            _dct = DCT;
            _målingContainer = målingContainer;

        }

        private void UIKontor_KnapLogud_Click(object sender, EventArgs e)
        {
            this.Close();
            UILogind logind = new UILogind(LL,_dct,_målingContainer);
            logind.Show();
        }

        private void UIKontor_KnapIndskriv_Click(object sender, EventArgs e)
        {
            UIKontor_KnapGem.Enabled = true;
            UIKontor_KnapAnnuller.Enabled = true;
            UIKontor_KnapIndskriv.Enabled = false;
            UIKontor_TextBoxFornavn.Enabled = true;
            UIKontor_TextBoxEfternavn.Enabled = true;
            UIKontor_TextBoxCPR1.Enabled = true;
            UIKontor_TextBoxStue1.Enabled = true;
            UIKontor_Indlæggelsesdato.Enabled = true;
            UIKontor_TextBoxSysMin.Enabled = true;
            UIKontor_TextBoxSysMax.Enabled = true;
            UIKontor_TextBoxDiaMin.Enabled = true;
            UIKontor_TextBoxDiaMax.Enabled = true;
        }

        private void UIKontor_KnapAnnuller_Click(object sender, EventArgs e)
        {
            UIKontor_KnapGem.Enabled = false;
            UIKontor_KnapAnnuller.Enabled = false;
            UIKontor_KnapIndskriv.Enabled = true;
            UIKontor_TextBoxFornavn.Enabled = false;
            UIKontor_TextBoxFornavn.Clear();
            UIKontor_TextBoxEfternavn.Enabled = false;
            UIKontor_TextBoxEfternavn.Clear();
            UIKontor_TextBoxCPR1.Enabled = false;
            UIKontor_TextBoxCPR1.Clear();
            UIKontor_TextBoxStue1.Enabled = false;
            UIKontor_TextBoxStue1.Clear();
            UIKontor_Indlæggelsesdato.Enabled = false;
            UIKontor_TextBoxSysMin.Enabled = false;
            UIKontor_TextBoxSysMin.Clear();
            UIKontor_TextBoxSysMax.Enabled = false;
            UIKontor_TextBoxSysMax.Clear();
            UIKontor_TextBoxDiaMin.Enabled = false;
            UIKontor_TextBoxDiaMin.Clear();
            UIKontor_TextBoxDiaMax.Enabled = false;
            UIKontor_TextBoxDiaMax.Clear();
            UIKontor_TextBoxCPR2.Clear();
            UIKontor_TextBoxStue2.Clear();
        }

        private void UIKontor_KnapGem_Click(object sender, EventArgs e)
        {
            PatientDTO Patient = new PatientDTO();
            if (UIKontor_TextBoxCPR1.Text == "" || UIKontor_TextBoxStue1.Text == "" ||
                UIKontor_TextBoxFornavn.Text == "" || UIKontor_TextBoxEfternavn.Text == "" ||
                UIKontor_TextBoxSysMin.Text == "" || UIKontor_TextBoxSysMax.Text == "" || 
                UIKontor_TextBoxDiaMin.Text == "" || UIKontor_TextBoxDiaMax.Text == "")
                MessageBox.Show("Udfyld venligst alle felter.");
            else
            {
                if (UIKontor_TextBoxCPR1.Text.Length != 10)
                {
                    MessageBox.Show("Patient data kan ikke gemmes, da CPR-nr. ikke er den rigtige længde. Prøv igen.");
                }
                else
                {
                    Patient.Fornavn = UIKontor_TextBoxFornavn.Text;
                    Patient.Efternavn = UIKontor_TextBoxEfternavn.Text;
                    Patient.CPR = UIKontor_TextBoxCPR1.Text;
                    Patient.IndlæggelsesDato = UIKontor_Indlæggelsesdato.Value;
                    Patient.SysMinimum = Convert.ToInt32(UIKontor_TextBoxSysMin.Text);
                    Patient.SysMaximum = Convert.ToInt32(UIKontor_TextBoxSysMax.Text);
                    Patient.DiaMinimum = Convert.ToInt32(UIKontor_TextBoxDiaMin.Text);
                    Patient.DiaMaximum = Convert.ToInt32(UIKontor_TextBoxDiaMax.Text);
                    UIKontor_TextBoxCPR2.Text = UIKontor_TextBoxCPR1.Text;
                    UIKontor_TextBoxStue2.Text = UIKontor_TextBoxStue1.Text;
                    LL.GemPatient(Patient);
                    UIKontor_KnapGem.Enabled = false;
                    UIKontor_KnapAnnuller.Enabled = false;
                    UIKontor_KnapUdskriv.Enabled = true;
                    UIKontor_KnapStart.Enabled = true;
                    UIKontor_TextBoxCPR1.Enabled = false;
                    UIKontor_TextBoxStue1.Enabled = false;
                    UIKontor_TextBoxFornavn.Enabled = false;
                    UIKontor_TextBoxEfternavn.Enabled = false;
                    UIKontor_Indlæggelsesdato.Enabled = false;
                    UIKontor_TextBoxSysMin.Enabled = false;
                    UIKontor_TextBoxSysMax.Enabled = false;
                    UIKontor_TextBoxDiaMin.Enabled = false;
                    UIKontor_TextBoxDiaMax.Enabled = false;
                }
            }

        }

        private void UIKontor_TextBoxCPR1_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(UIKontor_TextBoxCPR1.Text, "[^0-9]"))
            {
                MessageBox.Show("Skriv venligst kun tal.");
                UIKontor_TextBoxCPR1.Text = UIKontor_TextBoxCPR1.Text.Remove(UIKontor_TextBoxCPR1.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxStue1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(UIKontor_TextBoxStue1.Text, "[^0-9]"))
            {
                MessageBox.Show("Skriv venligst kun tal.");
                UIKontor_TextBoxStue1.Text = UIKontor_TextBoxStue1.Text.Remove(UIKontor_TextBoxStue1.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxSysMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(UIKontor_TextBoxSysMin.Text, "[^0-9]"))
            {
                MessageBox.Show("Skriv venligst kun tal.");
                UIKontor_TextBoxSysMin.Text = UIKontor_TextBoxSysMin.Text.Remove(UIKontor_TextBoxSysMin.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxSysMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(UIKontor_TextBoxSysMax.Text, "[^0-9]"))
            {
                MessageBox.Show("Skriv venligst kun tal.");
                UIKontor_TextBoxSysMax.Text = UIKontor_TextBoxSysMax.Text.Remove(UIKontor_TextBoxSysMax.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxDiaMin_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(UIKontor_TextBoxDiaMin.Text, "[^0-9]"))
            {
                MessageBox.Show("Skriv venligst kun tal.");
                UIKontor_TextBoxDiaMin.Text = UIKontor_TextBoxDiaMin.Text.Remove(UIKontor_TextBoxDiaMin.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxDiaMax_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(UIKontor_TextBoxDiaMax.Text, "[^0-9]"))
            {
                MessageBox.Show("Skriv venligst kun tal.");
                UIKontor_TextBoxDiaMax.Text = UIKontor_TextBoxDiaMax.Text.Remove(UIKontor_TextBoxDiaMax.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxFornavn_TextChanged(object sender, EventArgs e)
        {
            if (!UIKontor_TextBoxFornavn.Text.All(fornavn => char.IsLetter(fornavn)))
            {
                MessageBox.Show("Skriv venligst kun bogstaver");
                UIKontor_TextBoxFornavn.Text = UIKontor_TextBoxFornavn.Text.Remove(UIKontor_TextBoxFornavn.Text.Length - 1);
            }
        }

        private void UIKontor_TextBoxEfternavn_TextChanged(object sender, EventArgs e)
        {
            
            if (!UIKontor_TextBoxEfternavn.Text.All(efternavn => char.IsLetter(efternavn)))
            {
                MessageBox.Show("Skriv venligst kun bogstaver");
                UIKontor_TextBoxEfternavn.Text = UIKontor_TextBoxEfternavn.Text.Remove(UIKontor_TextBoxEfternavn.Text.Length - 1);
            }
        }

        private void UIKontor_KnapStart_Click(object sender, EventArgs e)
        {
            
            UIPatient pat = new UIPatient(UIKontor_TextBoxFornavn.Text + " " + UIKontor_TextBoxEfternavn.Text, UIKontor_Indlæggelsesdato.Value, LL,_dct, _målingContainer,UIKontor_TextBoxDiaMax.Text,UIKontor_TextBoxDiaMin.Text,UIKontor_TextBoxSysMax.Text, UIKontor_TextBoxSysMin.Text);
            pat.Show();
            _farve = true;
            if (_farve == true)
            {
                UIKontor_FarveIndikator.BackColor = Color.Black;
            }
        }


        
    }
}
