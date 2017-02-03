using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP.BAD
{
    public class TxtLogWriter
    {
        public void LogToFile(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("---   Ecrit dans un fichier   ---");
        }
    }
}
