using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.BAD
{
    public interface ILogger
    {
        void WriteLog(string message);
    }

    public class FileLogger : ILogger
    {
        public void WriteLog(string message)
        {
            
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void WriteLog(string message)
        {
            
        }
    }

    public class Controller
    {
        private readonly ILogger _logger;
        public Controller(ILogger logger)
        {
            _logger = logger;
        }

        public void Do()
        {
            _logger.WriteLog("saloute");
        }
    }

    class Program
    {
        public void Main()
        {
            new Controller(new DatabaseLogger());
        }    
    }
}
