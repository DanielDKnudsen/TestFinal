using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class DataContainer : DataContainerSubject
    {
        public void Done()
        {
            Notify();

        }
    }
}
