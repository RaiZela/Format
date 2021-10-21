using System;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Zgjidh figuren qe do te perdoresh: ");
                Console.WriteLine("1.Trekendesh");
                Console.WriteLine("2.Paralelogram");
                Console.WriteLine("3.Drejtkendesh");
                Console.WriteLine("4.Katror");

                int zgjedhja_fig = Convert.ToInt32(Console.ReadLine());

                switch(zgjedhja_fig)
                {
                    case 1:

                        Console.WriteLine("Vendos permasat e brinjeve: ");

                        Console.WriteLine("Brinja 1: ");
                        double Brinja1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Brinja 2: ");
                        double Brinja2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Brinja 3: ");
                        double Brinja3 = Convert.ToInt32(Console.ReadLine());

                        

                       
                       
                        break;

                    case 2:
                         Console.WriteLine("Vendos permasat e brinjeve: ");

                         Console.WriteLine("Brinja 1: ");
                         double brinja1_paralelogrami = Convert.ToInt32(Console.ReadLine());

                         Console.WriteLine("Brinja 2: ");
                         double brinja2_paralelogrami = Convert.ToInt32(Console.ReadLine());

                         Kuadratiket paralelogrami = new Kuadratiket(brinja1_paralelogrami,brinja2_paralelogrami);

                         paralelogrami.PrintimiLlogaritjeve(2);

                    break;

                    case 3:
                         Console.WriteLine("Vendos permasat e brinjeve: ");

                         Console.WriteLine("Brinja 1: ");
                         double brinja1_drejtkendeshi = Convert.ToInt32(Console.ReadLine());

                         Console.WriteLine("Brinja 2: ");
                         double brinja2_drejtkendeshi = Convert.ToInt32(Console.ReadLine());

                         Kuadratiket drejtkendeshi = new Kuadratiket(brinja1_drejtkendeshi, brinja2_drejtkendeshi);

                         drejtkendeshi.PrintimiLlogaritjeve(3);
                    break;

                    case 4:
                         Console.WriteLine("Vendos permasen e brinjes: ");

                         Console.WriteLine("Brinja: ");
                         double brinja = Convert.ToInt32(Console.ReadLine());

                         Kuadratiket katrori = new Kuadratiket(brinja,brinja);

                         katrori.PrintimiLlogaritjeve(4);

                    break;

                default:
                    Console.WriteLine("Zgjedhje e pavlefshme!");
                    break;

                }
        }
    }
}
