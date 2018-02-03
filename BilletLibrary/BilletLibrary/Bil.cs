using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : KøretøjBaseClass    //vi arver fra vores baseclass
    {
        public Bil(string nummerplade, DateTime date, bool brobizz, int standartPris) : base(nummerplade, date, brobizz, standartPris)
        {

        }

        public override string køreTøj()   //Metode vi skal override, da den er abstract i baseclasse
        {
            return "bil";
        }

        public override int PrisForBillet()       //tjekker weekend og brobizz
        {
            return weekendRabat();
        }

        private int weekendRabat()                              //metoden er private, da det kun er classen bil der skal bruge udregningen. 
        {
            if (((DaysOfWeek == DayOfWeek.Saturday) || (DaysOfWeek == DayOfWeek.Sunday)) && (BroBizz == true))
            {
                int rabat20procent = (StandartPris - (StandartPris * 20) / 100);
                return (rabat20procent - (rabat20procent * 5) / 100);
            }
            if(BroBizz == true)
            {
                PrisMedBrobizz();         //Vi har allerede lavet en metode der kan finde ud af at trække 5% fra, som ligger i 
                                          //så den bruger vi bare (da bil arver fra køretøj).
            }
            return StandartPris;        //hvis du det ikke er weekend og du heller ikke har brobizz, betaler man den fuld pris (240) 
        }




            //public Bil()
            //{
            //}

            //public string Nummerplade { get; set; }
            //public DateTime Dato { get; set; }


            //public int pris()
            //{
            //    return 240;
            //}

            //public string køreTøj()
            //{
            //    return "bil";
            //}

        }
    }
