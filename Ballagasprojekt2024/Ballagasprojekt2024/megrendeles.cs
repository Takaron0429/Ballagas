using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballagasprojekt2024
{
    internal class megrendeles
    {
        public int ugyid;
        public int cikkszam;
        public string allapot;
        public string mennyiseg;

        public megrendeles(int ugyid, int cikkszam, string allapot, string mennyiseg) 
        {
            this.ugyid = ugyid;
            this.cikkszam = cikkszam;
            this.allapot = allapot;
            this.mennyiseg = mennyiseg;
        }

       
    }
}
