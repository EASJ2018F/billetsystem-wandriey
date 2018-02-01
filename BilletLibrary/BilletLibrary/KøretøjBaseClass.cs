using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class KøretøjBaseClass
    {
        private string _nummerplade;
        private DateTime _datetime;
        private bool _brobizz;
        private int _pris;

        public string Nummerplade { get { return _nummerplade; } set { _nummerplade = value; } }
        public DateTime Dato { get { return _datetime; } set { _datetime = value; } }
        public bool BroBizz { get { return _brobizz; } set { _brobizz = value; } }
       


        public KøretøjBaseClass(string nummerplade, DateTime date, bool brobizz, int pris)
        {
            _datetime = date;
            _brobizz = brobizz;
            _pris = pris;


            if (nummerplade.Length > 7)
            { throw new ArgumentException("nummerpladens længde er store end 8");}        //Vi ønsker ikke der kan oprettes bil med en nummerplade
            _nummerplade = nummerplade;                                                    //der er længere end 7 bogstaver/tal
                                                                                          //hvis man prøver, vil der blive smidt en exception. 
        }

        public int PrisMedBrobizz()
        {
            if (BroBizz == false)
            { return Pris(); }

            return (_pris * 5) / 100;
         
        }
        public int Pris()
        {
            return _pris;
        }
        public abstract string køreTøj();
    }
}


