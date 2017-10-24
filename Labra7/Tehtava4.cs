using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Labra7
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }
        public int Numero { get; set; }
        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string kätisyys)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
        public override string ToString()
        {
            return "Nimi: " + Etunimi +" "+ Sukunimi + "\nPelipaikka:" + Pelipaikka + "\nKätisyys: " + Kätisyys;
        }
    }
    class Seura
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }
        public Seura(string nimi, string kaupunki)
        {
            Pelaajat = new List<Pelaaja>();
            Nimi = nimi;
            Kaupunki = kaupunki;
            HaePelaajat();
        }
        public void HaePelaajat()
        {
            Pelaajat.Add(new Pelaaja("Teemu", "Selänne", "H", "R"));
            Pelaajat.Add(new Pelaaja("Ville", "Leino", "H", "L"));
        }
        public override string ToString()
        {
            string retval = "Joukkue: " + Nimi + "\nKaupunki: " + Kaupunki + "\n*Pelaajat: ";
            foreach (Pelaaja item in Pelaajat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }
    }
    public class Tehtava4
    {
        public static void TestSeura()
        {
            const string f = "D:\\joukkuedata.txt";
            Seura Jyp = new Seura("Jyp", "Jyväskylä");
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(f))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
            Jyp.Pelaajat.Add(new Pelaaja("Ville", "Leino", "H", "L"));
            using (StreamWriter writer = new StreamWriter("D:\\joukkuedata.txt", false))
            {
                foreach (var p in Jyp.Pelaajat)
                {
                    writer.WriteLine(p.ToString());
                }
            }    
        }
    }
}
