using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerHomeWorkAlevel
{
    class Actions
    {
        Logger log = Logger.GetInstance();

        public void MethodFirst()
        {
            Console.WriteLine(Logger.NewMessage(GlobalConstant.Info, "Start method:"));
            
        }
        public void MethodSecond()
        {
            Console.WriteLine(Logger.NewMessage(GlobalConstant.Warning, "Skipped logic in method:"));
        }
        public void MethodThird()
        {
            throw new Exception("I broke a toilet");
        }
    }
}
