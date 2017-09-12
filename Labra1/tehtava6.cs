using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava6
    {
        public static void t6()
        {
            float travel;           
            Console.Write("Anna matka > ");
            travel = float.Parse(Console.ReadLine());
            Console.Write("Bensaa kuluu " + travel / 100 * 7.02 + "litraa, kustannus " + travel / 100 * 7.02 * 1.595 + "euroa");
        }
    }
}
