using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHomeWorkAlevel
{
    class Actions
    {
        public void MethodFirst()
        {
            Logger.NewMessage(GlobalConstant.Info, "Start method:");
        }
        public void MethodSecond()
        {
            Logger.NewMessage(GlobalConstant.Warning, "Skipped logic in method:");
        }
        public void MethodThird()
        {
            throw new Exception("I broke a toilet");
        }
    }
}
