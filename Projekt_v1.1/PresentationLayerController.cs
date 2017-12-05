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
        private MålingContainer _målingContainer;

        public PresentationLayerController(ILogikLayer ll, DataContainer DCT, MålingContainer målingContainer)
        {
            LL = ll;
            _dct = DCT;
            _målingContainer = målingContainer;
        }


        public void startUpGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new UILogind(LL,_dct,_målingContainer));
        }
    }
}
