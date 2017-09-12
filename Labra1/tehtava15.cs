using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava15
    {
        public static void t15()
        {
            int height;
            int width = 1;
            int space;

            Console.WriteLine("Anna puun korkeus ");
            height = int.Parse(Console.ReadLine());
            space = height;
            for (int i = 0; i < height - 2; i++)
            {
                
                for (int b = 0; b < space - 3; b++)
                {
                    Console.Write(" ");
                }
                space--;

                for (int b = 0; b < width; b++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
                width = width + 2;
            }

            //kannon tulostus
            for (int i = 0; i < 2; i++)
            {
                for (int b = 0; b < height - 3; b++)
                {
                    Console.Write(" ");
                }
                Console.Write("* \n");
            }
        }
    }
}

