using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCP.BAD
{
    public class Logger
    {
        
        private TypeLog _typelog;

        public  Logger(TypeLog typelog)
        {
            _typelog=typelog;
        }

        public void WriteLog(string message)
        {
            switch (_typelog)
            {
                case TypeLog.File:
                    WriteInFile(message);
                    break;
                case TypeLog.DataBase:
                    WriteInDataBase(message);
                    break;
                default:
                    break;
            }
        }

        private void WriteInFile(string message)
        {//Do stuff
        }

        private void WriteInDataBase(string message)
        {//Do stuff
        }
     
    }

    public enum TypeLog
    { 
        File,
        DataBase
    }

    
}
