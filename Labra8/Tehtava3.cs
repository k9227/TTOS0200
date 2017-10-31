using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Labra8
{
    class Tehtava3
    {
        public static void TestTehtava3()
        {
            try
            {
                List<int> Integers = new List<int>();
                List<double> Doubles = new List<double>();
                string fileDouble = @"D:\temp\double.txt";
                string fileInteger = @"D:\temp\integer.txt";
                string input;
                int outputInteger;
                double outputDouble;
                int i = 100;
                StreamWriter swd = new StreamWriter(fileDouble);
                StreamWriter swi = new StreamWriter(fileInteger);
                do
                {
                    Console.Write("Anna numero: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out outputInteger))
                    {
                        Integers.Add(outputInteger);
                        //tiedostoon kirjoitus voitaisiin tehdä myös suoraan täällä
                        //silloin listoja ei tarvittaisi
                    }
                    else if (double.TryParse(input, out outputDouble))
                    {
                        Doubles.Add(outputDouble);
                    }
                    else
                    {
                        break;
                    }                    
                } while (i==100);
                foreach (var line in Integers)
                {
                    swi.WriteLine(line);
                }
                foreach (double line in Doubles)
                {
                    swd.WriteLine(line);
                }
                swi.Close();
                swd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
