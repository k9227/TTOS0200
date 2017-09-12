using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava13
    {
        public static void t13()
        {
            int lowest=999999999;
            int highest=0;
            int sum=0;
            int score=0;
           
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna pisteet > ");

                score = int.Parse(Console.ReadLine());
                if (lowest > score)
                {
                    lowest = score;
                }
                if(highest < score)
                {
                    highest = score;
                }
                sum = score + sum;
            }
            sum = sum - lowest - highest;
            Console.WriteLine("Koknaispisteet ovat " +sum);
        }
    }
}
