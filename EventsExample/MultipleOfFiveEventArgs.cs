using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
   public class MultipleOfFiveEventArgs : EventArgs
    {
        public MultipleOfFiveEventArgs(int iTotal)
        { 
            Total = iTotal; // se podrá llamar des del constructor como des de la propiedad
        }

        public int Total { get; set;}

    }
}
