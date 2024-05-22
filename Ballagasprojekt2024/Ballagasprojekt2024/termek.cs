using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballagasprojekt2024
{
    internal class termek
    {
        public termek (string neve, string leiras, int cikkszam, int ar)
        {
            this.neve = neve;
            this.leiras = leiras;
            this.cikkszam = cikkszam;
            this.ar = ar;
        }

        public string neve { get; set; }
        public string leiras { get; set; }
        public int cikkszam { get; set; }
        public int ar { get; set; }

    }
}
