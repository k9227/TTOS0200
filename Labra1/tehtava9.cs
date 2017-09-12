using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava9
    {
        public static void t9()
        {
            int sum=0;
            int input=1;

            while (input != 0)
            {
                Console.Write("Anna luku > ");
                input = int.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.Write("Lukujen summa on " + sum);
        }
    }
}
