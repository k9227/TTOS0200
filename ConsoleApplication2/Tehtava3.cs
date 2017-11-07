using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Fish> Fishes { get; }
        public Person()
        {
            Fishes = new List<Fish>();
        }
        public void AddFish(Fish fish)
        {
            Fishes.Add(fish);
        }
        public override string ToString()
        {
            string s="";
            foreach (Fish f in Fishes)
            {
                s += "Fisher: " + Name + " " + Phone + "\n" + f.ToString() + "\n\n";
            }
            return s;
        }
    }
    public class Fish
    {
        public string Species { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }
        public string Lake { get; set; }
        public string City { get; set; }
        public Fish(string species,int length,double weight,string lake, string city)
        {
            Species = species;
            Length = length;
            Weight = weight;
            Lake = lake;
            City = city;
        }
        public override string ToString()
        {
            return string.Format("-specie : {0} {1}cm {2}kg \n-place : {3}\n-location: {4}", Species, Length, Weight, Lake, City);            
        }
    }
    class Tehtava3
    {
        public static void TestTehtava3()
        {
            try
            {
                Person kirsi = new Person { Name="Kirsi",Phone="0401234567"};
                Fish kala = new Fish("Salmon", 75, 3.7, "Pyhäjärvi", "Karkkila");
                Fish kala1 = new Fish("Pike", 113, 11.2, "Jyväsjärvi", "Jyväskylä");
                Fish kala2 = new Fish("Burbot", 70, 4, "Massakoski", "Karkkila");
                kirsi.AddFish(kala);
                kirsi.AddFish(kala1);
                kirsi.AddFish(kala2);           
                Console.WriteLine(kirsi.ToString()+"\nFishes ordered by weight:\n");
                kirsi.Fishes.Sort((x, y) => y.Weight.CompareTo(x.Weight));
                Console.WriteLine(kirsi.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
