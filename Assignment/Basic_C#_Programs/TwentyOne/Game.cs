﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
	public abstract class Game
	{
		public string Name { get; set; }

		private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
		public Dictionary<Player, int> Bets 
		{ 
			get { return _bets; }  
			set { _bets = value; } 
		}


		private List<Player> _players = new List<Player>();
		public List<Player> Players 
		{ 
			get { return _players; } 
			set { _players = value; } 
		}
		
		public abstract void Play();

		public virtual void ListPlayers()
		{
			foreach(Player player in Players) 
			{
				Console.WriteLine(player);
			}
		}
	}
}
