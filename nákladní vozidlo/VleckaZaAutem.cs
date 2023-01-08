using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nákladní_vozidlo
{
    internal class VleckaZaAutem : NakladniAuto
    {
        double nosnost_V;
        public VleckaZaAutem(string spz, double nosnost, double hmotnost, double Nosnost_Vlecky) : base(spz, nosnost, hmotnost)
        {
            nosnost_V = Nosnost_Vlecky;
        }

        public double Vlecka_Nosnost()
        {
            return nosnost_V;
        }
    }
}
