
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP.BAD
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger("win");

            // mon programme démarre et il 
            // faut le loguer 
            logger.Log("Début du démarrage du programme");

            Console.ReadKey();
        }
    }

}
