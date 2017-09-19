using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Pelikokoelma
    {
        public string Nimi { get; set; }
        public string Alusta { get; set; }
        public string Vuosi { get; set; }
        public string Julkaisija { get; set; }

        public Pelikokoelma(string nimi, string alusta, string vuosi, string julakisija)
        {
            Nimi = nimi;
            Alusta = alusta;
            Vuosi = vuosi;
            Julkaisija = julakisija;
        }
    }
       public class PelikokoelmaDemo
        {
            public static void TestaaPelikokoelma()
            {
                List<Pelikokoelma> Kaikkipelit = new List<Pelikokoelma>();
                string jatka = "";
                while (jatka == "")
                {                
                Console.WriteLine("Syötä tiedot järjestyksessä\nNimi -- Genre -- Vuosi -- Julkaisija");
                Kaikkipelit.Add(new Pelikokoelma(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
                Console.WriteLine("Jatkaaksesi syöttämistä paina enter, poistuaksesi kirjoita jotain kenttään ja paina enter");
                jatka = Console.ReadLine();
            }
                for (int i = 0; i < Kaikkipelit.Count; i++)
                {
                
                Console.WriteLine("Nimi " + Kaikkipelit[i].Nimi);
                Console.WriteLine("Genre " + Kaikkipelit[i].Alusta);
                Console.WriteLine("Vuosi " + Kaikkipelit[i].Vuosi);
                Console.WriteLine("Julkaisija " + Kaikkipelit[i].Julkaisija);
                
                //Tiedot tallennetaan myös tekstitiedostona D-levyn juureen
                using (StreamWriter writer = new StreamWriter("D:\\pelit.txt", true))
                {
                    writer.WriteLine("Nimi " + Kaikkipelit[i].Nimi);
                    writer.WriteLine("Genre " + Kaikkipelit[i].Alusta);
                    writer.WriteLine("Vuosi " + Kaikkipelit[i].Vuosi);
                    writer.WriteLine("Julkaisija " + Kaikkipelit[i].Julkaisija);
                    writer.WriteLine("\n");
                }
            }
            }

        }
    }

