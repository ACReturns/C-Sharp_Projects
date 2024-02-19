using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame(); // Polymorphism
            game.Players = new List<string>() { "Don", "Vivi", "Laila" };
            game.ListPlayers();
            Console.ReadLine();
            
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards) 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        #region parameter notes
        // default value assigned so it is an optional parameter
        // out parameters are always before any optional parameters
        /*
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) 
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }

                deck.Cards = TempList;
            }
            return deck;
        }
        */
        #endregion
    }
}
