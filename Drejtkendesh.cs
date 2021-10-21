using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Drejtkendesh : Paralelogram
    {
       
        public Drejtkendesh(double Brinja1, double Brinja2) : base(Brinja1,Brinja2)
        {
           
        }

        public override double LlogaritSiperfaqen()
        {
            double siperfaqa = Brinja1 * Brinja2;
            return siperfaqa;
        }
    }
}
