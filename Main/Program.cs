﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using LogikLayer;
using Projekt_v1._1;

namespace Main
{
    class Program
    {
        private static LogikController LC;
        private static PresentationController PC;
        private static DataController DC;
        private static int t = 4;
        private static int q = 10;
        private static int k = 100000;
        private static int h = 90;

        static void Main(string[] args)
        {
            Program currentApp = new Program();
        }

        public Program()
        {
            DC = new DataController();
            LC = new LogikController(DC);
            PC = new PresentationController(LC);
            PC.StartUpUILogind();
        }
    }
}
