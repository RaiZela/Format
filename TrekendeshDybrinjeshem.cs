using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class TrekendeshDybrinjeshem : TreKendesh
    {
        public TrekendeshDybrinjeshem(double Brinja, double Baza) : base(Brinja, Baza, Brinja)
        {

        }

        public override double LlogaritLartesine()
        {
            double lartesia = Math.Sqrt(Math.Pow(Brinja, 2) - Math.Pow((Baza / 2), 2));
            return lartesia;
        }

        public override double LlogaritSiperfaqen()
        {
            double lartesia = LlogaritLartesine();
            double sip = ((Baza * lartesia) / 2);
            return sip;

        }
    }
}

