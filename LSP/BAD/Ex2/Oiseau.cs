using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.BAD.Ex2
{
    public class Oiseau
    {
        public virtual void Manger()
        {
            Console.WriteLine("Je suis un oiseau et je mange...");
        }

        public virtual void Voler()
        {
            Console.WriteLine("Je suis un oiseau et je vole...");
        }
    }
}
