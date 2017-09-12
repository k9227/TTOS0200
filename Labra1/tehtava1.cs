using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava1
    {
        public static void t1()
        {
            int luku;
            Console.Write("Anna luku 1,2 tai 3 ");
            luku = int.Parse(Console.ReadLine());

            if(luku>=1 & luku <= 3)
            {
                if (luku == 1)
                {
                    Console.Write("yksi");
                }
                if (luku == 2)
                {
                    Console.Write("kaksi");
                }
                if (luku == 3)
                {
                    Console.Write("kolme");
                }
             }
              else
            {
                Console.Write("Joku muu luku");
            }
        }

    }
}
