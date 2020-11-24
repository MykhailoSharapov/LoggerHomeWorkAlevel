using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHomeWorkAlevel
{
    class Logger
    {
        private Logger()
        {

        }
        private static Logger instance;

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }
}
