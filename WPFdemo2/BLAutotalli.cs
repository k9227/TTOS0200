using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFdemo2
{
    public static class Autotalli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //GUIn testaamista varten keksitään muutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 2007;
            a.KM = 200000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);
            //TOinen auto
            Auto b = new Auto();
            b.Merkki = "Audi";
            b.Malli = "A4";
            b.VM = 2008;
            b.KM = 345000;
            b.Hinta = 11000F;
            b.URL = "AudiA4.png";
            autot.Add(b);
            Auto c = new Auto();
            c.Merkki = "Saab";
            c.Malli = "99";
            c.VM = 1998;
            c.KM = 750000;
            c.Hinta = 1000F;
            c.URL = "";
            autot.Add(c);
            Auto d = new Auto();
            d.Merkki = "Toyota";
            d.Malli = "Corolla";
            d.VM = 1997;
            d.KM = 175000;
            d.Hinta = 1500F;
            d.URL = "Corolla.jpg";
            autot.Add(d);
            //palautus
            return autot;
        }
    }
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }
        public int KM { get; set; }
        public float Hinta { get; set; }
        public string URL { get; set; }
    }
}
