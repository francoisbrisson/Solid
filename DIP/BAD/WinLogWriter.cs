using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP.BAD
{
    public class WinLogWriter
    {
        public void LogToEventLog(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("---   Ecrit dans un journal Windows   ---");
        }
    }
}
