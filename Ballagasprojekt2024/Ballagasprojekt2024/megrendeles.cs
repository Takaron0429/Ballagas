using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballagasprojekt2024
{
    internal class megrendeles
    {
        public megrendeles(int ugyid, int cikkszam, string allapot, string mennyiseg) 
        {
            this.ugyid = ugyid;
            this.cikkszam = cikkszam;
            this.allapot = allapot;
            this.mennyiseg = mennyiseg;
        }

        public int ugyid { get; set;}
        public int cikkszam { get; set;}
        public string allapot { get; set;}  
        public string mennyiseg { get; set;}
    }
}
