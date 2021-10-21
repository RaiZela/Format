using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Katror : Drejtkendesh 
    {
        public double Brinja { get; set; }
        public Katror(double Brinja) : base(Brinja, Brinja)
        {
            this.brinja = brinja1;
        }

        public override double LlogaritSiperfaqen()
        {
            double sip = Math.Pow(Brinja, 2);
            return sip;
        }
    }
}
