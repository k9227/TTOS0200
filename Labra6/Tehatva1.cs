using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Rengas
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public string Rengaskoko { get; set; }
        public Rengas() { }
        public Rengas(string merkki,string tyyppi,string rengaskoko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Rengaskoko = rengaskoko;
        }
        public override string ToString()
        {
            return "Merkki: " + Merkki + "\nTyyppi: " + Tyyppi + "\nKoko: " + Rengaskoko;
        }
    }
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public List<Rengas> Renkaat { get; set; }
        public Kulkuneuvo()
        {
            Renkaat = new List<Rengas>();
            Renkaat.Add(new Labra6.Rengas("Pirelli", "Black", "15"));
        }

        public override string ToString()
        {
            string retval = "Automerkki: " + Nimi + "\nMalli: " + Malli +"\nRenkaiden tiedot: ";
            foreach(Rengas item in Renkaat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;            
        }
    }
    public class Tehtava1
    {
        public static void TestRengas()
        {
            Kulkuneuvo auto = new Kulkuneuvo();
            auto.Nimi = "Toyota";
            auto.Malli = "Corolla";
            Kulkuneuvo auto2 = new Kulkuneuvo();
            auto2.Nimi = "Nissan";
            auto2.Malli = "Almera";

            Console.WriteLine(auto.ToString()+auto2.ToString());
        }
    }
}
