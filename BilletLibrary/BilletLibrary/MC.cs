using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }


        public int pris()
        {
            return 125;
        }

        public string køreTøj()
        {
            return "MC";
        }
    }
}
