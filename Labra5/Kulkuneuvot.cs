using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Kulkuneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Väri { get; set; }

        public Kulkuneuvo(string nimi,string malli,int vuosimalli,string väri)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;
        }
    }

    class Pyörä : Kulkuneuvo
    {
        public bool Vaihteet { get; set; }
        private string vaihteisto;
        public string Vaihteisto
        {//get;set;
           get
            {
                return vaihteisto;
            }
            set
            {
                if (Vaihteet == true)
                {
                    Vaihteisto = value;
                }
                if (Vaihteet == false)
                {
                    vaihteisto = "-";
                }
            }
        }

        public Pyörä(string nimi, string malli, int vuosimalli, string väri,bool vaihteet,string vaihteisto)
            : base(nimi,malli,vuosimalli,väri)
        {
            Vaihteet = vaihteet;
            Vaihteisto = vaihteisto;
        }
    }

    class Vene : Kulkuneuvo
    {
        public string Tyyppi { get; set; }
        public int Istumapaikat { get; set; }
        public Vene(string nimi, string malli, int vuosimalli, string väri, string tyyppi, int istumapaikat)
            : base(nimi,malli,vuosimalli,väri)
        {
            Tyyppi = tyyppi;
            Istumapaikat = istumapaikat;
        }
    }

    public class Tehtava5
    {
        public static void TestTehtava5()
        {
            Kulkuneuvo kulkuneuvo = new Kulkuneuvo("Toyota", "Corolla", 1997, "punainen");
            Pyörä pyörä = new Pyörä("Helkama", "Jopo", 2001, "Vihreä", true, "Shinamo");
            Vene vene = new Vene("SeaStar","720",2011,"Valkoinen","moottorivene",5);
            Vene vene2 = new Vene("GIMLI", "6000", 1983, "Valkoinen", "soutuvene", 2);

            Console.WriteLine(kulkuneuvo.Nimi + " " + kulkuneuvo.Malli + " " + kulkuneuvo.Vuosimalli + " " + kulkuneuvo.Väri);
            Console.WriteLine(pyörä.Nimi + " " + pyörä.Malli + " " + pyörä.Vuosimalli + " " + pyörä.Väri+" "+ pyörä.Vaihteet +" " + pyörä.Vaihteisto);
            Console.WriteLine(vene.Nimi + " " + vene.Malli + " " + vene.Vuosimalli + " " + vene.Väri + " " + vene.Tyyppi + " " + vene.Istumapaikat);

            pyörä.Vaihteet = false;
            pyörä.Nimi = "Tunturi";
            pyörä.Malli = "Kiitäjä";

            Console.WriteLine(pyörä.Nimi + " " + pyörä.Malli + " " + pyörä.Vuosimalli + " " + pyörä.Väri + " " + pyörä.Vaihteet + " " + pyörä.Vaihteisto);
            Console.WriteLine(vene2.Nimi + " " + vene2.Malli + " " + vene2.Vuosimalli + " " + vene2.Väri + " " + vene2.Tyyppi + " " + vene2.Istumapaikat);
        }
    }
}
