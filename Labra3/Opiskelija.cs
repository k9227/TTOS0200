using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public string Tunnus { get; set; }
        public string Luokka { get; set; }

        public Opiskelija(string nimi,string tunnus,string luokka)
        {
            Nimi = nimi;
            Tunnus = tunnus;
            Luokka = luokka;
        }
    }

    class OpiskelijaDemo
    {
        public static void TestaaOpiskelija()
        {
            List<Opiskelija> Opiskelijat = new List<Opiskelija>();
            Opiskelijat.Add(new Opiskelija("Kalle", "k9213", "9F"));
            Opiskelijat.Add(new Opiskelija("Pentti", "k9435", "8B"));
            Opiskelijat.Add(new Opiskelija("Minna", "k4983", "7A"));
            Opiskelijat.Add(new Opiskelija("Heikki", "k0324", "8D"));
            Opiskelijat.Add(new Opiskelija("Kalle", "k5423", "7B"));
            //esim näin voitaisiin ottaa tietoja käyttäjän syötteestä helposti
           // Opiskelijat.Add(new Opiskelija(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));

            for (int i = 0; i < Opiskelijat.Count; i++)
            {
                Console.WriteLine("Nimi " + Opiskelijat[i].Nimi);
                Console.WriteLine("Tunnus " + Opiskelijat[i].Tunnus);
                Console.WriteLine("Luokka " + Opiskelijat[i].Luokka);
            }
        }
        
    }

}

