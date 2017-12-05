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
using ObserverPatternVol2;
using PresentationLayer;

namespace Projekt_v1._1
{
    public partial class UIMed : Form
    {
        private ILogikLayer LL;
        private string _brugernavn;
        private DataContainer _dct;
        private string fortsæt;
        public UIMed(ILogikLayer ll, string brugernavn,DataContainer DCT)
        {
            InitializeComponent();
            LL = ll;
            _brugernavn = brugernavn;
            _dct = DCT;
        }

        private void UIMed_buttonLogud_Click(object sender, EventArgs e)
        {
            this.Close();
            UILogind logind = new UILogind(LL,_dct);
            logind.Show();
        }

        private void UIMed_buttonStartKalibrering_Click(object sender, EventArgs e)
        {
            int mmHg = 10;            
            bool gentag10 = true;
            bool gentag50 = true;
            bool gentag100 = true;

            for (int i = 0; i < 1; i++)
            {
                while (gentag10)
                {
                    bool NO = true;
                    MessageBox.Show(
                        "Tilslut transducer til 10mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 10 mmHg.");

                    if (LL.StartKalibrering(mmHg))
                    {
                        MessageBox.Show("Måling blev foretaget korrekt. Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 50 mmHg");
                        gentag10 = false;
                        LL.setKali(mmHg);
                    }
                    else
                    {
                        while (NO == true)
                        {
                            DialogResult diares = MessageBox.Show("Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'", "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                            if (diares == DialogResult.Yes)
                            {
                                gentag10 = false;
                                LL.setKali(mmHg);
                                NO = false;
                            }
                            else
                            {
                                DialogResult prøvigen = MessageBox.Show("Vil du prøve igen?", "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                                if (prøvigen == DialogResult.Yes)
                                {
                                    gentag10 = true;
                                    LL.setKali(mmHg);
                                    NO = false;
                                }
                                if (prøvigen == DialogResult.No)
                                {
                                    gentag10 = false;
                                    gentag50 = false;
                                    gentag100 = false;
                                    i = 2;
                                    NO = false;
                                }
                            }
                        }
                    }
                }
                while (gentag50)
                {
                    bool NO = true;
                    MessageBox.Show(
                        "Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 50 mmHg.");

                    if (LL.StartKalibrering(mmHg))
                    {
                        MessageBox.Show(
                            "Måling blev foretaget korrekt. Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 100 mmHg");
                        gentag50 = false;
                        LL.setKali(mmHg);
                    }
                    else
                    {
                        while (NO == true)
                        {
                            DialogResult diares = MessageBox.Show(
                                "Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'",
                                "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                            if (diares == DialogResult.Yes)
                            {
                                gentag50 = false;
                                LL.setKali(mmHg);
                                NO = false;
                            }
                            else
                            {
                                DialogResult prøvigen = MessageBox.Show("Vil du prøve igen?", "Værdier udenfor grænsen",
                                    MessageBoxButtons.YesNo);
                                if (prøvigen == DialogResult.Yes)
                                {
                                    gentag50 = true;
                                    LL.setKali(mmHg);
                                    NO = false;
                                }
                                if (prøvigen == DialogResult.No)
                                {
                                    gentag10 = false;
                                    gentag50 = false;
                                    gentag100 = false;
                                    i = 2;
                                    NO = false;
                                }
                            }
                        }
                    }
                }
                while (gentag100)
                {
                    bool NO = true;
                    MessageBox.Show(
                        "Tilslut transducer til 100mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 100 mmHg.");

                    if (LL.StartKalibrering(mmHg))
                    {
                        MessageBox.Show("Måling blev foretaget korrekt. Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 100 mmHg");
                        gentag100 = false;
                        LL.setKali(mmHg);
                    }
                    else
                    {
                        while (NO == true)
                        {
                            DialogResult diares = MessageBox.Show(
                                "Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'",
                                "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                            if (diares == DialogResult.Yes)
                            {
                                gentag100 = false;
                                LL.setKali(mmHg);
                                NO = false;
                            }
                            else
                            {
                                DialogResult prøvigen = MessageBox.Show("Vil du prøve igen?", "Værdier udenfor grænsen",
                                    MessageBoxButtons.YesNo);
                                if (prøvigen == DialogResult.Yes)
                                {
                                    gentag100 = true;
                                    LL.setKali(mmHg);
                                    NO = false;
                                }
                                if (prøvigen == DialogResult.No)
                                {
                                    gentag10 = false;
                                    gentag50 = false;
                                    gentag100 = false;
                                    i = 2;
                                    NO = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void UIMed_buttonStartNulpunktsjustering_Click(object sender, EventArgs e)
        {
            NulpunktsMED();
        }
        public void NulpunktsMED()
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
                        NulpunktsMED();
                        NO = false;
                    }
                    if (PrøvIgen == DialogResult.No)
                    {
                        NO = false;
                    }
                }
            }
            
        }

        private void UIMed_Knap_VisGraf_Click(object sender, EventArgs e)
        {
            
            KalibreringGraf K1 = new KalibreringGraf(LL.kalibliste());
            
            K1.Show();
        }
    }
}
