using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labra5
{
    class Radio
    {
        readonly int[] volumevalues = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (volumevalues.Contains(value))
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Volumen tulee olla: 0, 1, 2,..., tai 9");
                }
            }
        }
        private double freq;
        public double Freq
        {
            get
            {
                return freq;
            }
            set
            {
                if (2000 <= value && value <= 2600)
                {
                    freq = value;
                }
                else
                {
                    Console.WriteLine("Taajuuden tulee olla välillä 2000,0 - 2600,0");
                }
            }
        }
        private bool powerstate;
        public bool Powerstate
        {
            get
            {
                return powerstate;
            }
            set
            {
                if(value==true || value == false)
                {
                    powerstate = value;
                }
                else
                {
                    Console.WriteLine("Arvoksi tulee antaa true tai false");
                    powerstate=false;
                }
            }
        }
    }
    public class Tehtava6
    {        
        public static void TestTehtava6()
        {
            Radio radio = new Radio();
            int choose;
            Console.WriteLine("Kirjoita true käynnistääksesi radion.");
            radio.Powerstate = true;//bool.Parse(Console.ReadLine());
            while (radio.Powerstate == true)
            {
                Console.Write("1. Volume {0}\n2. Taajuus {1:0.##}\n   Virta {2}\n9. Sulje radio\n", radio.Volume,radio.Freq,radio.Powerstate);
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:                
                        radio.Volume = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Aseta haluamasi taajuus.");
                        radio.Freq = double.Parse(Console.ReadLine());
                        break;
                    case 9:
                        radio.Powerstate = false;
                        break;             
                }                
            }           
        }
    }
}
