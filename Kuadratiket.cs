using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class Kuadratiket : DyDimensional
    {
        public double Brinja1 { get; set; }
        public double Brinja2 { get; set; }
        public Kuadratiket(double Brinja1, double Brinja2)
        {
            this.Brinja1 = Brinja1;
            this.Brinja2 = Brinja2;
 
        }

        public void PrintimiLlogaritjeve(int x)
        {
            if(x==2)
            {
                Paralelogram paralelogrami = new Paralelogram(brinja1, brinja2);
                Console.WriteLine("Perimetri i paralelogramit eshte: " + paralelogrami.LlogaritPerimetrin());
            }

            else if(x==3)
            {
                Drejtkendesh drejtkendeshi = new Drejtkendesh(brinja1,brinja2) ;
                Console.WriteLine("Perimetri i drejtkendeshit eshte: "+drejtkendeshi.LlogaritPerimetrin());
                Console.WriteLine("Siperfaqa e drejtkendeshit eshte: " + drejtkendeshi.LlogaritSiperfaqen());
            }

            else if(x==4)
            {
                Katror katrori = new Katror(brinja1);
                Console.WriteLine("Perimetri i katrorit eshte: " + katrori.LlogaritPerimetrin());
                Console.WriteLine("Siperfaqa e katrorit eshte: " + katrori.LlogaritSiperfaqen());
            }
        }

        public override double LlogaritPerimetrin()
        {
            double p = 2*(Brinja1+Brinja2);
            return p;

        }
    }
}
