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

        public string Nummerplade { get { return _nummerplade; } set { _nummerplade = value; } }
        public DateTime Dato { get { return _datetime; } set { _datetime = value; } }
        public DayOfWeek DaysOfWeek { get { return _daysOfWeek; } set { _daysOfWeek = value; } }
        public bool BroBizz { get { return _brobizz; } }
        public int StandartPris { get { return _standartPris; } set { _standartPris = value; } }   //retunere den oprindelige pris (bil = 240, MC = 125)



        public KøretøjBaseClass(string nummerplade, DateTime date, bool brobizz, int standartPris)
        {
            _datetime = DateTime.Now;
            _daysOfWeek = DateTime.Now.DayOfWeek;
            _datetime = date;
            _standartPris = standartPris;
            _brobizz = brobizz;
            
            if (nummerplade.Length > 7)
            { throw new ArgumentException("nummerpladens længde er store end 8");}       //Vi ønsker ikke der kan oprettes bil med en nummerplade
            _nummerplade = nummerplade;                                                  //der er længere end 7 bogstaver/tal
        }                                                                                //hvis man prøver, vil der blive smidt en exception. 


        public int PrisMedBrobizz()                                    
        {
            if (!BroBizz)
            { return StandartPris; }

            return (StandartPris - (StandartPris * 5) / 100);
         
        }
        public int prisOverØresundsbro()                       //metoder der regner ud hvad du skal betale, hvis du køre over øresundsbroen. 
        {
          
            if (køreTøj() == "bil")
            {
                if (!BroBizz) { return 410; }
                return 161;
            }
            if (køreTøj() == "MC")
            {
                if (!BroBizz) { return 210; }
                return 73;
            }
            return 0;                            //Hvad kunnde man gøre istedet? 0 er måske ikke optimal 
        }

        public abstract int PrisForBilletStorebæltOgLille();

        public abstract string køreTøj();


    }
}


