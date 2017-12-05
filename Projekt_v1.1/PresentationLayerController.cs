using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using Projekt_v1._1;
using ObserverPatternVol2;


namespace PresentationLayer
{
    public class PresentationLayerController : IPresentationLayer
    {
        private ILogikLayer LL;
        private DataContainer _dct;

        public PresentationLayerController(ILogikLayer ll, DataContainer DCT)
        {
            LL = ll;
            _dct = DCT;
        }


        public void startUpGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new UILogind(LL,_dct));
        }
    }
}
