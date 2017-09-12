using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava8
    {
        public static void t8()
        {
            int number;
            int bignumber = -2147483648; //pienin mahdollinen arvo
            
            Console.Write("Anna kolme kokonaislukua > ");
            for (int i = 0; i < 3; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number > bignumber)
                {
                    bignumber = number;
                }
            }
            Console.Write("Suurin luku on " + bignumber);
        }
    }
}
