using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Loggers
{
    class FileLogger : ILogger
    {
        public string Log(string info)
        {
            return $"{info} logged to File.";
        }
    }
}
