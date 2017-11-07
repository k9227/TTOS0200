using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    class Dice
    {
        public int Number { get; set; }        
        public Dice(int number)
        {
            Number = number;
        }
        public Dice() { }
        public override string ToString()
        {
            return string.Format("{0}",Number);
        }
    }
    class Tehtava1
    {
        public static void TestaaTehtava1()
        {
            try
            {
                Random rng = new Random();
                Dice dice = new Dice();
                List<int> results = new List<int>();
                double sum = 0;
                dice.Number = rng.Next(0, 7);
                Console.WriteLine(dice.ToString());
                Console.WriteLine("Kuinka monta kertaa noppaa heitetään: ");
                int repeats = int.Parse(Console.ReadLine());
                for (int i = 0; i < repeats; i++)
                {
                    dice.Number = rng.Next(1, 7);
                    sum += dice.Number;
                    results.Add(dice.Number);
                }
                Dictionary<int, int> Names = new Dictionary<int, int>();
                foreach (int line in results)
                {
                    if (Names.ContainsKey(line))
                    {
                        Names[line] += 1;
                    }
                    else
                    {
                        Names.Add(line, 1);
                    }
                }
                int allNames = 0;
                foreach (KeyValuePair<int, int> kvp in Names)
                {
                    allNames += kvp.Value;
                }
                //Esittäminen aakkostettuna
                var namesList = Names.Keys.ToList();
                namesList.Sort();
                Console.WriteLine("Heitit noppaa {0} kertaa. \nHeittojen keskiarvo oli {1}", repeats, sum / repeats);
                foreach (var key in namesList)
                {
                    Console.WriteLine("{0}: {1}", key, Names[key]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
