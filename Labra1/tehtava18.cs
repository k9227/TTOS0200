using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava18
    {
        static public void t18()
        {
            string input;
            string check="";
            
            Console.Write("Anna sana/lause palidromi tarkastukseen > ");
            input = Console.ReadLine();

            //syötteen kääntäminen.
            //
            for (int i = input.Length -1; i >= 0; i--)
            {
                check += input[i];
            }
            if (check == input)
            {
                Console.WriteLine("On palidromi.");
            }
            else
            {
                Console.WriteLine("Ei ole palidromi.");
            }
        }
    }
}
