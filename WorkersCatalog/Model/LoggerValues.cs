using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersCatalog.Model
{
    public class LoggerValues
    {
        public bool isTrace { get; set; }
        public bool isDebug { get; set; }
        public bool isWarning { get; set; }
        public bool isError { get; set; }
        public bool isFatal { get; set; }
        public bool isToText { get; set; }
        public bool isToBin { get; set; }
        public bool isToDatabase { get; set; }
        public bool isLogging { get; set; }
    }
}
