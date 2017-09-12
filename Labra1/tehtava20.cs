using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava20
    {
        static public void t20()
        {
            string yes = "Valehtelet :D:D:D:";
            string no = "No totta turiset";
            int input;

            Console.Write("Riittikö tehtävänantoon luovuus ? \n 1.Kyllä \n 2.Ei \n");
            input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                Console.WriteLine(yes);
            }
            if (input == 2)
            {
                Console.WriteLine(no);
            }
        }
    }
}
