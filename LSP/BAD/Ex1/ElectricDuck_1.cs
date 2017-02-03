using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.BAD
{
    public class ElectricDuck : Duck
    {

        public bool SwitchOn { get; set; }
        public override void Fly()
        {

            if (!SwitchOn)
                SwitchOn = true;
            base.Fly();
        }
    }
}
