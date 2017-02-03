using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSP.BAD;
using System.Diagnostics;

namespace LSP
{
    sealed class Program
    {
        static void Main(string[] args)
        {
            List<Duck> myList = new List<Duck>() { new Duck(), new ElectricDuck(), new Duck() };
            Exemple1(myList);
        }

        private static void Exemple1(List<Duck> myList )
        {
            
            int nbDucks = 0;

            foreach (var duck in myList)
            {

                if (duck is ElectricDuck)
                    ((ElectricDuck)duck).SwitchOn = true;
                duck.Fly();


                if (duck.State == DuckState.Fly)
                    nbDucks++;
            }

            Debug.Assert(nbDucks == myList.Count, "All ducks are not in the sky!!");
        }


        
    }
}
