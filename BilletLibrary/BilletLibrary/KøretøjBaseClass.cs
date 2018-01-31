using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class KøretøjBaseClass
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; } 


        public abstract int Pris();

        public abstract string køreTøj();
    }
}
