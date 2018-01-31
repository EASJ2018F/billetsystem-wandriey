using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : KøretøjBaseClass    //vi arver fra vores baseclass
    {
        public Bil(string nummerplade, DateTime date, bool brobizz) : base(nummerplade, date, brobizz)
        {
            
        }

        public override string køreTøj()   //Metode vi skal override, da den er abstract i baseclasse
        {
            return "bil";
        }

        public override int Pris()
        {
            return 240;
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
