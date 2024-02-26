using System;
using System.IO;
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
			Console.WriteLine("Welcome to the table, please tell me your name.");
			string playerName = Console.ReadLine();

			Console.WriteLine("How much are you looking to spend today?");
			int playerMoney = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Hello {0}, do you want to play a game of 21?", playerName);
			string playerAnswer = Console.ReadLine().ToLower();

			if (playerAnswer == "yes" || playerAnswer == "yeah" || playerAnswer == "ya" || playerAnswer == "y")
			{
				Player player = new Player(playerName, playerMoney);
				Game game = new TwentyOneGame();
				game += player;
				player.isActivelyPlaying = true;

				while (player.isActivelyPlaying && player.Balance > 0)
				{
					game.Play();
				}
				game -= player;
				Console.WriteLine("Thanks for playing!");
			}
			Console.WriteLine("Feel free to look around, bye for now.");
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
