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

        public UIMed(ILogikLayer ll)
        {
            InitializeComponent();
            LL = ll;
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
            bool gentag = true;
            
            while (gentag)
                {
                    MessageBox.Show(
                        "Tilslut transducer til 10mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 10 mmHg.");

                    if (LL.StartKalibrering(mmHg))
                    {
                        MessageBox.Show("Måling blev foretaget korrekt. Tilslut transducer til 50mmHg. Tryk 'OK' når du er klar til at starte kalibrering med 50 mmHg");
                        gentag = false;
                        LL.setKali(mmHg);
                    }
                    else
                    {
                        DialogResult diares = MessageBox.Show("Værdien for målingen er udenfor grænsen - Vil du godkende værdien og fortsætte kalibrering så tryk 'YES'", "Værdier udenfor grænsen", MessageBoxButtons.YesNo);
                        if (diares == DialogResult.Yes)
                        {
                            gentag = false;
                            LL.setKali(mmHg);
                        }
                        else
                        {
                            gentag = true;
                        }
                    }
                }
            }
        }
    }
