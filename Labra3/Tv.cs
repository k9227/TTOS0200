using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Tv
    {
        public int Kanava { get; set; }
        public bool Epg { get; set; }
        public bool Päällä { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Kanava " + Kanava);
            Console.WriteLine("Epg " + Epg);
            Console.WriteLine("Päällä " + Päällä);
        }

    }

    class TvDemo
    {
        public static void TestaaTv()
        {
            //Console.WriteLine("Syötä arvot: Lämpö, Kosteus sekä onko kiuas päällä (true tai false). Paina eneteriä jolloin pääset aina syöttämään seuraavaa arvoa");
            //Kiuas puuKiuas = new Kiuas(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            Tv nokia = new Tv();
            nokia.Päällä = false;
            nokia.Epg = false;
            nokia.Kanava = 0;

            Console.WriteLine("1. Aseta TV päälle kirjoittamalla true");
            nokia.Päällä = bool.Parse(Console.ReadLine());
            while (nokia.Päällä == true)
            {
                Console.WriteLine("1. Kanava \n2. EPG(On/off) \n9. Sulje");
                int valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    nokia.Kanava = int.Parse(Console.ReadLine());
                }
                if (valinta == 2)
                {
                    switch (nokia.Epg)
                    {
                        case true:
                            nokia.Epg = false;
                            break;
                        case false:
                            nokia.Epg = true;
                            break;
                    }             
                }
                if (valinta == 9)
                {
                    nokia.Päällä = false;
                }
                nokia.PrintData();
            }


        }
    }
}


