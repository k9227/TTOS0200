using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava3
    {
        public static void t3()
        {
            float number = 0;
            float input = 0;

            Console.Write("Give three numbers ");
            for (int i = 0; i < 3; i++)
            {
                input = float.Parse(Console.ReadLine());
                number = number + input;
            }
            number = number / 3;
            Console.Write("Average of given numbers is " + number);
                
        }
    }
}
