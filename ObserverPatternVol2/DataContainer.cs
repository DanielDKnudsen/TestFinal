﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternVol2
{
    public class DataContainer : DataContainerSubject
    {
        public void Done(Queue<double> _queue)
        {
            Notify(_queue);

        }
    }
}