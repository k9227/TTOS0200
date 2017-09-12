using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava12
    {
        public static void t12()
        {
            int[] numbers = new int[5];

            Console.Write("Anna 5 lukua ");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Luvut takaperin ");
            for (int i = 4; i > -1; i--)
            {
                Console.Write("" + numbers[i]+",");
            }
        }
    }
}
