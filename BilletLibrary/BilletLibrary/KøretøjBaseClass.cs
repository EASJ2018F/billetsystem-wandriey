using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class KøretøjBaseClass
    {
        private int _pris;

        public string Nummerplade { get; set;}
        public DateTime Dato { get; set; }
        public bool BroBizz { get; set; }
        
       

        public KøretøjBaseClass(string nummerplade, DateTime date, bool brobizz)
        {
            Dato = date;
            BroBizz = brobizz;
      

            if (nummerplade.Length > 7)
            { throw new ArgumentException("nummerpladens længde er store end 8");}        //Vi ønsker ikke der kan oprettes bil med en nummerplade
            Nummerplade = nummerplade;                                                    //der er længere end 7 bogstaver/tal
                                                                                          //hvis man prøver, vil der blive smidt en exception. 
        }

        public int PrisMedBrobizz()
        {
            if (BroBizz == false)
            { return Pris(); }

            return (Pris() / 100) * 95;
         
        }
        public abstract int Pris();
        public abstract string køreTøj();
    }
}


