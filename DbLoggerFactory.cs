using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Loggers
{
    class DbLoggerFactory : ILoggerFactory
    {
        public ILogger Create()
        {
            return new DbLogger();
        }
    }
}
