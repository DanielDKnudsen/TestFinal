﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using DTO;
using ObserverPatternVol2;

namespace Projekt_v1._1
{
    public partial class UILogind : Form
    {
        private ILogikLayer LL;
        private DataContainer _dct;
        private MålingContainer _målingContainer;

        public UILogind(ILogikLayer ll,DataContainer DCT, MålingContainer målingContainer)
        {
            InitializeComponent();
            LL= ll;
            _dct = DCT;
            _målingContainer = målingContainer;
        }

        private void UILogind_buttonLogind_Click(object sender, EventArgs e)
        {
            LogindDTO LDTO = new LogindDTO();
            LDTO.Brugernavn = UILogind_textBoxBrugernavn.Text;
            LDTO.Kodeord = UILogind_textBoxKodeord.Text;
            if (UILogind_radioButtonSunhedspersonale.Checked)
            {
                LDTO.IsSundhed = true;
            }
            else
                LDTO.IsSundhed = false;

            int værdi = LL.RequestLogind(LDTO);

            // Her åbnes forms afhængig af login
            
            if (værdi == 1)
            {
                UIKontor1 kontor = new UIKontor1(LL,_dct,_målingContainer);
                this.Hide();
                kontor.Show();
            }
            if (værdi == 2)
            {
                UIMed med = new UIMed(LL, UILogind_textBoxBrugernavn.Text,_dct,_målingContainer);
                this.Hide();
                med.Show();
                
            }
            if (værdi == 0)
            {
                MessageBox.Show("Brugernavn eller kodeord er forkert, prøv igen.");
                UILogind_textBoxBrugernavn.Clear();
                UILogind_textBoxKodeord.Clear();
            }
        }
    }
}
