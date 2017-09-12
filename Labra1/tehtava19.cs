using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class tehtava19
    {
        static public void t19()
        {
            string word="kissa";
            char input;
            int check;
            int tries=0;
            int victory = word.Length;
            string[] rightword = new string[word.Length];

            //taulukon alustus 
            //halutessa helppo muuttaa sanaa/asettaa se käyttäjän valittavaksi
            for (int i = 0; i <= word.Length - 1; i++)
            {
                rightword[i] = ("_");
            }
            Console.WriteLine("Arvaa sanassa esiintyvä kirjain > ");

                //pelin mekaniikka
                while (tries<5)
            {
                input = Console.ReadKey().KeyChar;
                Console.Write("\n");
                check = 0;

                for (int i = 0; i <= word.Length-1; i++)
                {           
                    if (input == word[i])
                    {
                        rightword[i] = input.ToString();
                        check=1;
                        victory--;
                    }
                }

                if (check == 0)
                {
                    Console.Write("Kirjainta ei esiinny sanassa.");
                    tries++;
                }

                for (int i = 0; i <= word.Length - 1; i++)
                {
                    Console.Write(rightword[i]);
                }
                Console.Write(victory);

                if (victory == 0)
                {
                    Console.WriteLine("Voitit pelin.");
                    break;
                }
            }
        }
    }
}
