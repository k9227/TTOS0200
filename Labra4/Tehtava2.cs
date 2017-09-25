using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Tehtava2
    {      
        private int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    kerros = value;                                  
                }
                if (value > 5)
                {
                    Console.WriteLine("Hissi ei kulje näin korkealle.");
                }
                if (value < 1)
                {
                    Console.WriteLine("Hissi ei kulje näin matalalle.");
                }
            }
        }        
    }
    public static class TestiPeti2
    {
        public static void TestHissi()
        {
            {
                Tehtava2 hissi = new Tehtava2();
                hissi.Kerros = 1;
                while (true)
                {
                    Console.WriteLine("Olet kerroksessa " + hissi.Kerros);
                    Console.WriteLine("Valitse kerros > ");
                    hissi.Kerros = int.Parse(Console.ReadLine());
                }                
            }
        }
    }
}
