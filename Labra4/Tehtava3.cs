using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Tehtava3
    {
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
                if (value>100)
                {
                    Console.WriteLine("Asettamasi volume liian korkea.");
                    volume = 100;
                }
                if (value < 0)
                {
                    Console.WriteLine("Asettamasi volume liian matala.");
                    volume = 0;
                }
            }
        }
    }
    public static class TestiPeti3
    {
        public static void TestVahvistin()
        {
            {
                Tehtava3 amp = new Tehtava3();
                while (true)
                {
                    Console.WriteLine("Volume " + amp.Volume);
                    Console.WriteLine("Aseta volume (0-100) > ");
                    amp.Volume = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
