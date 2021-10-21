using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class TreKendesh : DyDimensional
    {
        public double Brinja1 { get; set; }

        public double Brinja2 { get; set; }

        public double Brinja3 { get; set; }

        public double Brinja { get; set; }

        public double Baza { get; set; }

        public TreKendesh(double Brinja1, double Brinja2, double Brinja3)
        {
            this.Brinja1 = Brinja1;
            this.Brinja2 = Brinja2;
            this.Brinja3 = Brinja3;
        }

        public void KontrolliVlerave()
        {
            int vleraAfishimit = ZgjedhjaVleresSeAfishimit();
            int lloji_trekendeshit = 0;

            //Trekendeshi DyBrinjeshem
            if (Equals(Brinja1, Brinja2) && !(Brinja1 == Brinja3))
            {
                lloji_trekendeshit = 2;
                brinja = brinja1;
                baza = brinja3;
            }

            else if (Equals(Brinja1, Brinja3) && !(Brinja1 == Brinja2))
            {
                lloji_trekendeshit = 2;
                Brinja = Brinja3;
                Baza = Brinja2;
            }

            else if (Equals(Brinja2, Brinja3) && !(Brinja1 == Brinja3))
            {
                lloji_trekendeshit = 2;
                Brinja = Brinja2;
                Baza = Brinja1;

                Console.WriteLine("Trekendeshi eshte dybrinjeshem. ");
            }



            //Trekendeshi eshte barabrinjes
            if (Equals(Brinja1, Brinja2) && Equals(Brinja1, Brinja3) && Equals(Brinja2, Brinja3))
            {
                lloji_trekendeshit = 1;

                Console.WriteLine("Trekendeshi eshte barabrinjes. ");

            }



            //Trekendeshi i cfaredoshem
            if (Brinja1 != Brinja2 && Brinja1 != Brinja3 && Brinja2 != Brinja3)
            {
                lloji_trekendeshit = 3;
                Console.WriteLine("Trekendeshi eshte i cfaredoshem. ");
            }

            Printimi(lloji_trekendeshit, vleraAfishimit);
        }

        public override double LlogaritPerimetrin()
        {
            double perimetri = Brinja1 + Brinja2 + Brinja3;
            return perimetri;
        }

        public void Printimi(int lloji, int vlera)
        {
            TreKendesh trekendeshi = null;

            if (lloji == 1)
            {
                Brinja = Brinja1;
                trekendeshi = new TrekendeshBarabrinjes(Brinja);
            }

            if (lloji == 2)
            {
                trekendeshi = new TrekendeshDybrinjeshem(Brinja, Baza);
            }

            if (lloji == 3)
            {
                trekendeshi = new TrekendeshICfaredoshem(Brinja1, Brinja2, Brinja3);
            }


            if (vlera == 1)
            {
                Console.WriteLine("Perimetri i trekendeshit eshte: " + trekendeshi.LlogaritPerimetrin());
            }

            if (vlera == 2)
            {
                Console.WriteLine("Siperfaqja e trekendeshit eshte: " + trekendeshi.LlogaritSiperfaqen());
            }

            if (vlera == 3)
            {
                Console.WriteLine("Lartesia e trekendeshit eshte: " + trekendeshi.LlogaritLartesine());
            }

            if (vlera == 4)
            {
                Console.WriteLine("Perimetri i trekendeshit eshte: " + trekendeshi.LlogaritPerimetrin());
                Console.WriteLine("Siperfaqja e trekendeshit eshte: " + trekendeshi.LlogaritSiperfaqen());
                Console.WriteLine("Lartesia e trekendeshit eshte: " + trekendeshi.LlogaritLartesine());

            }

        }

    }

}