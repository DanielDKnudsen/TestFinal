using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace Projekt_v1._1
{
    public partial class UIMed : Form
    {
        private ILogikLayer LL;
        private string _brugernavn;

        public UIMed(ILogikLayer ll, string brugernavn)
        {
            InitializeComponent();
            LL = ll;
            _brugernavn = brugernavn;

        }

        private void UIMed_buttonLogud_Click(object sender, EventArgs e)
        {
            this.Close();
            UILogind logind = new UILogind(LL);
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
                        DialogResult diares = MessageBox.Show("Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'", "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                        if (diares == DialogResult.Yes)
                        {
                            gentag10 = false;
                            LL.setKali(mmHg);
                        }
                        else
                        {
                            gentag10 = true;
                        }
                    }
                }
                while (gentag50)
                {
                    MessageBox.Show(
                        "Tilslut transducer til 10mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 50 mmHg.");

                    if (LL.StartKalibrering(mmHg))
                    {
                        MessageBox.Show("Måling blev foretaget korrekt. Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 100 mmHg");
                        gentag50 = false;
                        LL.setKali(mmHg);
                    }
                    else
                    {
                        DialogResult diares = MessageBox.Show("Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'", "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                        if (diares == DialogResult.Yes)
                        {
                            gentag50 = false;
                            LL.setKali(mmHg);
                        }
                        else
                        {
                            gentag50 = true;
                        }
                    }
                }
                while (gentag100)
                {
                    MessageBox.Show(
                        "Tilslut transducer til 10mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 100 mmHg.");

                    if (LL.StartKalibrering(mmHg))
                    {
                        MessageBox.Show("Måling blev foretaget korrekt. Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 100 mmHg");
                        gentag100 = false;
                        LL.setKali(mmHg);
                    }
                    else
                    {
                        DialogResult diares = MessageBox.Show("Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'", "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                        if (diares == DialogResult.Yes)
                        {
                            gentag100 = false;
                            LL.setKali(mmHg);
                            if (i == 1)
                            {
                                LL.
                            }
                        }
                        else
                        {
                            gentag100 = true;
                        }
                    }
                }
            }
        }
    }
}
