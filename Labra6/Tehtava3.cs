using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }
        public Pelaaja(string etunimi,string sukunimi, string pelipaikka, string kätisyys)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
        public override string ToString()
        {
            return "\nNimi: " + Etunimi+Sukunimi + "\nPelipaikka:" +Pelipaikka+"\nKätisyys: " + Kätisyys;
        }
    }
    class Seura
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }
        public Seura()
        {
            Pelaajat = new List<Pelaaja>();
            Pelaajat.Add(new Pelaaja("Teemu", "Selänne", "H","R"));
            Pelaajat.Add(new Pelaaja("Ville", "Leino", "H", "L"));
        }
        public override string ToString()
        {
            string retval = "Joukkue: " + Nimi + "\nKaupunki: " + Kaupunki + "\n*Pelaajatt: ";
            foreach (Pelaaja item in Pelaajat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
    public class Tehtava3
    {
        public static void TestSeura()
        {
            Seura jokerit = new Seura();
            jokerit.Nimi = "Jokerit";
            jokerit.Kaupunki = "Helsinki";

            Console.WriteLine(jokerit.ToString());
        }
    }
}
