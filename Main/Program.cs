using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Interfaces;
using LogikLayer;
using PresentationLayer;
using Projekt_v1._1;

namespace Main
{
    class Program
    {
        private static ILogikLayer LL;
        private static IDataLayer DL;
        private static IPresentationLayer PL;
        private static Consumer C;

        static void Main(string[] args)
        {
            Program currentApp = new Program();
        }

        public Program()
        {
            DL = new DataController();
            LL = new LogikController(DL, C);
            PL = new PresentationLayerController(LL);
            PL.startUpGUI();
        }
    }
}
