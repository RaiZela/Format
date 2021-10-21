using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format
{
    class DyDimensional
    {
        public DyDimensional()
        {

        }



        public virtual double LlogaritPerimetrin()
        {
            return 0;
        }

        public virtual double LlogaritSiperfaqen()
        {
            return 0;
        }

        public virtual double LlogaritLartesine()
        {
            return 0;
        }

        public int ZgjedhjaVleresSeAfishimit()
        {
            Console.WriteLine("Zgjidh vleren qe do te afishosh: ");
            Console.WriteLine("1.Perimetri");
            Console.WriteLine("2.Siperfaqja");
            Console.WriteLine("3.Lartesia");
            Console.WriteLine("4.Te gjitha");

            int vleraEAfishimit = Convert.ToInt32(Console.ReadLine());

            return vleraEAfishimit;
        }
    }
}
