using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.BAD
{
    public class Duck
    {
        public DuckState State { get; private set; }


        public virtual void Fly()
        {
            State = DuckState.Fly;

            if (this.State != DuckState.Fly)
                throw new Exception();
        }
    }


    public enum DuckState
    {
        Rest,
        Fly
    }
}
