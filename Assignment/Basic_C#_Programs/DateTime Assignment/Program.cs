using System;

namespace DateTime_Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(DateTime.Now);
			Console.WriteLine("Please enter a number: ");
			int userResponse = Convert.ToInt32(Console.ReadLine());
			
			// Adds the number input as hours 
			DateTime futureTime = DateTime.Now.AddHours(userResponse);
			Console.WriteLine("In " + userResponse + " hours the time will be " + futureTime);
			Console.ReadLine();
		}
	}
}
