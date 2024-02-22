using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the current day of the week:");

			try
			{
				Console.WriteLine("The day you entered was " + Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine()));
			}
			catch (Exception ex) 
			{
				Console.WriteLine("Please enter an actual day of the week");
			}
			finally 
			{
				Console.ReadLine();
			}
		}

		public enum DaysOfTheWeek
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
	}
}
