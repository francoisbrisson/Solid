using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP.BAD
{
    public class Logger
    {
        private string _typeWriter;

        public Logger(string typeWriter)
        {
            _typeWriter = typeWriter;
        }


        public void Log(string message)
        {
            switch (_typeWriter)
            {
                case "txt":
                    TxtLogWriter txtLog = new TxtLogWriter();
                    txtLog.LogToFile(message);
                    break;
                case "win":
                    WinLogWriter winLog = new WinLogWriter();
                    winLog.LogToEventLog(message);
                    break;
            }
        }
    }
}
