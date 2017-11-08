using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_v1._1
{
    public partial class UIPatient : Form
    {
        
        public UIPatient(string navn)
        {
            InitializeComponent();
            UIPatient_LabelPatientNavn.Text = navn;
        }

        private void UIPatient_LabelPatientNavn_Click(object sender, EventArgs e)
        {
            

        }
    }
}
