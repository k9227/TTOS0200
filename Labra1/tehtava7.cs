using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava7
    {
        public static void t7()
        {
            int year;
            int check = 0;
            
            Console.Write("Anna vuosi > ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                check = 1;
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        check = 1;
                    }
                    else
                    {
                        check = 0;
                    }
                }
            }

            if (check == 1)
            {
                Console.Write("Vuosi on karkausvuosi.");
            }
            if (check == 0)
            {
                Console.Write("Vuosi ei ole karkausvuosi.");
            }
        }
    }
}
