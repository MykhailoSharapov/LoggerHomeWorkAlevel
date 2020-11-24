using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerHomeWorkAlevel
{
    class Logger
    {
        private Logger()
        {

        }
        private static Logger instance;
        private static List<string> LogMessages = new List<string>();
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }

        public static string NewMessage(string MessageLevel, Exception ex)
        {
            string result = $"{MessageLevel}, stack trace: {ex.StackTrace}, error message: {ex.Message}";
            LogMessages.Add(result);
            return result;
        }

        public static string NewMessage(string MessageLevel, string Message)
        {
            string result = $"{MessageLevel}, Message: {Message}";
            LogMessages.Add(result);
            return result;
        }

        public static void SaveLogFile()
        {
            File.AppendAllLines(DateTime.Now.Ticks.ToString() + ".txt", LogMessages);
        }
    }
}
