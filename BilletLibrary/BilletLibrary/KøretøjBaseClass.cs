using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class KøretøjBaseClass
    {
        public string Nummerplade { get; set;}
        public DateTime Dato { get; set; }

        public KøretøjBaseClass(string nummerplade, DateTime date)
        {
            Dato = date;
            if (nummerplade.Length > 7)
            { throw new ArgumentException("nummerpladens længde er store end 8");}        //Vi ønsker ikke der kan oprettes bil med en nummerplade
            Nummerplade = nummerplade;                                                    //der er længere end 7 bogstaver/tal
                                                                                          //hvis man prøver, vil der blive smidt en exception. 
        }                                                                        

        public abstract int Pris();

        public abstract string køreTøj();
    }
}


