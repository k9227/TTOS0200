using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Shelf
    {
        public string Name { get; set; }
        public string Year { get; set; }

        public Shelf()
        {
        }
        public virtual void PrintData()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Year " + Year);
        }
    }
    class Game : Shelf
    {
        public string Platform { get; set; }

        public Game()
        {
        }
        public override void PrintData()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Year " + Year);
            Console.WriteLine("Publisher" + Platform);
        }
    }
    class Bluray : Shelf
    {
        public string Genre { get; set; }
        public string Director { get; set; }

        public Bluray()
        {
        }

        public override void PrintData()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Year " + Year);
            Console.WriteLine("Genre " + Genre);
            Console.WriteLine("Director " + Director);
        }
    }
    class Comic : Shelf
    {
        public string Publisher { get; set; }
        public int Pages { get; set; }

        public Comic()
        {
        }

        public override void PrintData()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Year " + Year);
            Console.WriteLine("Publisher " + Publisher);
            Console.WriteLine("Pages " + Pages);
        }
    }    
    public class Tehtava7
    {
        public static void TestTehtava7()
        {
            Game game = new Game();
            game.Name = "Super Mario Bros";
            game.Year = "1983";
            game.Platform = "NES";

            Bluray bluray = new Bluray();
            bluray.Name = "Pulp Fiction";
            bluray.Year = "1994";
            bluray.Genre = "Crime";
            bluray.Director = "Quentin Tarantino";

            Comic comic = new Comic();
            comic.Name = "Batman: Year One";
            comic.Year = "1987";
            comic.Publisher = "DC Comics";
            comic.Pages = 96;

            game.PrintData();
            bluray.PrintData();
            comic.PrintData();
        }
    }
}
