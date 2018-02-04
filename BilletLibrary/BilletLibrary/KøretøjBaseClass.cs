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
        private int _standartPris;
        private DateTime _datetime;
        private DayOfWeek _daysOfWeek;
        private bool _brobizz;
        private bool _øresundbro;



        public string Nummerplade { get { return _nummerplade; } set { _nummerplade = value; } }
        public DateTime Dato { get { return _datetime; } set { _datetime = value; } }
        public DayOfWeek DaysOfWeek { get { return _daysOfWeek; } set { _daysOfWeek = value; } }
        public bool BroBizz { get { return _brobizz; } set { _brobizz = value; } }
        public int StandartPris { get { return _standartPris; } set { _standartPris = value; } }   //retunere den oprindelige pris (bil = 240, MC = 125)



        public KøretøjBaseClass(string nummerplade, DateTime date, bool brobizz, int standartPris, bool øresundbro)
        {
            _datetime = DateTime.Now;
            _daysOfWeek = DateTime.Now.DayOfWeek;
            _datetime = date;
            _standartPris = standartPris;
            _brobizz = brobizz;
            _øresundbro = øresundbro;
            

            if (nummerplade.Length > 7)
            { throw new ArgumentException("nummerpladens længde er store end 8");}        //Vi ønsker ikke der kan oprettes bil med en nummerplade
            _nummerplade = nummerplade;                                                    //der er længere end 7 bogstaver/tal
                                                                                          //hvis man prøver, vil der blive smidt en exception. 
        }

        public int PrisMedBrobizz()                                    //
        {
            if (!BroBizz)
            { return StandartPris; }

            return (StandartPris - (StandartPris * 5) / 100);
         
        }
        private int prisOverØresundsbro()
        {
            if (køreTøj() == "bil")
            { return 161; }
            if (køreTøj() == "MC")
            { return 73; }

            return _standartPris;
        }

        public abstract int PrisForBillet();

        public abstract string køreTøj();


    }
}


