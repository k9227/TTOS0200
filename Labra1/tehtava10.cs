using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava10
    {
        public static void t10()
        {
            int[] numbers = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < 9; i++)
            {
                if (numbers[i] % 2 == 0)
                { 
                    Console.WriteLine("" + numbers[i]+ " HEP");
                }
                else
                {
                    Console.WriteLine("" + numbers[i]);
                }
            }
        }
    }
}
