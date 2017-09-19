using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Kiuas
    {
        public int Lämpö { get; set; }
        public int Kosteus { get; set; }
        public bool Päällä { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Lämpö " + Lämpö);
            Console.WriteLine("Kosteus " + Kosteus);
            Console.WriteLine("Päällä " + Päällä);
        }

    }

    class KiuasDemo
    { 
        public static void TestaaKiuas()
        {
            //Console.WriteLine("Syötä arvot: Lämpö, Kosteus sekä onko kiuas päällä (true tai false). Paina eneteriä jolloin pääset aina syöttämään seuraavaa arvoa");
            //Kiuas puuKiuas = new Kiuas(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            Kiuas harvia = new Kiuas();
            harvia.Päällä = false;
            harvia.Lämpö = 0;
            harvia.Kosteus = 0;

            Console.WriteLine("1. Aseta kiuas päälle kirjoittamalla true");
            harvia.Päällä = bool.Parse(Console.ReadLine());
            while (harvia.Päällä == true)
            {
                Console.WriteLine("1. Lämpötila \n2. Kosteus \n9. Sulje");
                int valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    harvia.Lämpö = int.Parse(Console.ReadLine());
                }
                if (valinta == 2)
                {
                    harvia.Kosteus = int.Parse(Console.ReadLine());
                }
                if (valinta == 9)
                {
                    harvia.Päällä = false;
                }
                harvia.PrintData();
                
            }
            
            
        }
    }
}


