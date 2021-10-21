using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class TrekendeshICfaredoshem : TreKendesh
    {
        public TrekendeshICfaredoshem(double Brinja1, double Brinja2, double Brinja3) : base(Brinja1,Brinja2,Brinja3)
        {
        }

        public override double LlogaritSiperfaqen()
        {
            
                double lartesia = LlogaritLartesine();
                double siperfaqa = (Brinja1 * lartesia) / 2;
                return siperfaqa;
           
        }

        public override double LlogaritLartesine()
        {
            double lartesia = 0.5 * (Math.Sqrt((Brinja1 + Brinja2 + Brinja3) * ((-Brinja1) + Brinja2 + Brinja3) * (Brinja1 - Brinja2 + Brinja3) * (Brinja1 + Brinja2 - Brinja3))) / Brinja2;
            return lartesia;
        }
    }
}
