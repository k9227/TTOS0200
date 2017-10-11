using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class TestaaMiniASIO
    {
        static void Testaa()
        {
            //Luodaan list-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //testin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "T9876",Ryhmä="TTV17S1"});
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle";kalle.Sukunimi="Ankka";kalle.AsioID = "K6789";
            opiskelijat.Add(kalle);
            //yhden opiskelijan tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-{0}",opiskelijat.Count);
            int i = int.Parse(Console.ReadLine());
            if (i-1 < opiskelijat.Count)
                Console.WriteLine("MiniAsion {0} opiskelija on {1}", i, opiskelijat[i-1].ToString());
            else
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", opiskelijat.Count);
            //kakkien opiskelijoiden tiedot
            Console.WriteLine("\nMiniASIOn kaikki opiskelijat");
            foreach(var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //kaikkien opiskelijoiden tiedot aakkostettuna sukunimen mukaan
            //sortataan oliot Sukunimi-ominaisuude mukaiseen järjestykseen
            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("\nMiniASIOn kaikki opiskelijat aakkostettuna");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen, HUOM tarkistetaan ettei AdioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach (var o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhmä");
                string ryhma = Console.ReadLine();
                //luodaan uusi opiskelija
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("\nMiniASIOn kaikki {0} opiskelijaa:",opiskelijat.Count);
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
