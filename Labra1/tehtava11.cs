using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava11
    {
        public static void t11()
        {
            int input;
            string star = "*";
            Console.Write("Anna rivien määrä > ");
            input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                for (int b = -1; b < i; b++)
                {
                    Console.Write(star);
                }
                Console.Write("\n");
            }
        }
    }
}
