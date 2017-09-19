using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Pesukone
    {
        public int Lämpö { get; set; }
        public int Kesto { get; set; }
        public bool Päällä { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Lämpö " + Lämpö);
            Console.WriteLine("Kesto " + Kesto);
            Console.WriteLine("Päällä " + Päällä);
        }

    }

    class PesukoneDemo
    {
        public static void TestaaPesukone()
        {
            //Console.WriteLine("Syötä arvot: Lämpö, Kosteus sekä onko kiuas päällä (true tai false). Paina eneteriä jolloin pääset aina syöttämään seuraavaa arvoa");
            //Kiuas puuKiuas = new Kiuas(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), bool.Parse(Console.ReadLine()));
            Pesukone miele = new Pesukone();
            miele.Päällä = false;
            miele.Lämpö = 0;
            miele.Kesto = 0;

            Console.WriteLine("1. Aseta pesukone päälle kirjoittamalla true");
            miele.Päällä = bool.Parse(Console.ReadLine());
            while (miele.Päällä == true)
            {
                Console.WriteLine("1. Lämpötila \n2. Kesto\n3. Käynnistä ohjelma \n9. Sulje");
                int valinta = int.Parse(Console.ReadLine());
                if (valinta == 1)
                {
                    miele.Lämpö = int.Parse(Console.ReadLine());
                }
                if (valinta == 2)
                {
                    miele.Kesto = int.Parse(Console.ReadLine());
                }
                if (valinta == 3)
                {
                    Console.WriteLine("HURRR HURRR");
                    break;
                }
                if (valinta == 9)
                {
                    miele.Päällä = false;
                }
                miele.PrintData();
            }


        }
    }
}


