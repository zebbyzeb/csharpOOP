using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class LoggingService
    {
        public LoggingService()
        {
            this.outputLogs = new List<string>();
        }
        public List<string> outputLogs { get; private set; }

        public void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach (var item in itemsToLog)
            {
                outputLogs.Add(item.Log());
            }
        }
    }
}
