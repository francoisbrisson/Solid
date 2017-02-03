using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.BAD.Ex2
{
    public class Autruche : Oiseau
    {
        public override void Voler()
        {
            throw new NotSupportedException();
        }
    }
}
