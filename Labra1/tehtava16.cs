using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava16
    {
        public static void t16()
        {
            Random rnd = new Random();
            int randomnumber = rnd.Next(1, 101);
            int input=101;
            int counter=0;

            while (input != randomnumber)
            {
                Console.Write("Arvaa luku > ");
                input = int.Parse(Console.ReadLine());
                if (input < randomnumber)
                {
                    Console.WriteLine("Luku on suurempi.");
                }
                if (input > randomnumber)
                {
                    Console.WriteLine("Luku on pienempi.");
                }
                counter++;
            }
            Console.WriteLine("Hienoa, arvasit luvun " + counter + ". kerralla.");
        }
    }
}
