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
    }
}
