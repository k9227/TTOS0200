using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava14
    {
        public static void t14()
        {
            int grade = 0;
            int[] grades = new int[6];

            while (grade != 9)
            {
                Console.Write("Anna arvosana 0-5 (9 = exit) > ");
                grade = int.Parse(Console.ReadLine());
                if (grade == 9)
                {
                    break;
                }
                grades[grade] = grades[grade] +1;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write(i + ": ");
                for (int b = 0; b < grades[i]; b++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
