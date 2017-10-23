using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Card
    {        
        public string Suit { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Value, Suit);
        }        
    }
    static class ShuffleDeck
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    class Tehtava3
    {
        public static void TetKortti()
        {
            string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            List<Card> deck = new List<Card>();
            for (int s = 0; s < 4; s++)
            {
                for (int i = 1; i < 14; i++)
                {
                    deck.Add(new Card { Suit = suits[s], Value = i });
                }
            }
            foreach(var c in deck)
            { 
                Console.WriteLine(c.ToString());
            }
            deck.Shuffle();
            Console.WriteLine("*Pakka sekoitettuna*\n");
            foreach (var c in deck)
            {
                Console.WriteLine(c.ToString());
            }



        }
    } 
}
    
