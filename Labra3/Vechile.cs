using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Vechile
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }                
    
        public void PrintData()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Speed " + Speed);
            Console.WriteLine("Tyres " + Tyres);

            Console.WriteLine(Name + Speed + Tyres.ToString());
        }
       
    }

    public class VechileDemo
    {
        public static void TestaaVechile()
        {
            Vechile Corolla = new Vechile();
            Corolla.Name = "Toytota Corolla";
            Corolla.Speed = 200;
            Corolla.Tyres = 4;

            Corolla.PrintData(); 
        }
        
    }
}
