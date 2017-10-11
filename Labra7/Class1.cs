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
            Console.WriteLine("Anna numero väliltä 1-5");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("MiniAsion {0} opiskelija on {1}", i, opiskelijat[i].ToString());

        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
