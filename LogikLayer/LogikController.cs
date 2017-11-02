using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace LogikLayer
{
    public class LogikController : ILogikLayer
    {
        private Logind Log;

        public LogikController(Logind log)
        {
            Log = log;
        }

        public int RequestLogind(LogindDTO LDTO)
        {
            return Log.CheckValues(LDTO);
        }
       
    }
}
