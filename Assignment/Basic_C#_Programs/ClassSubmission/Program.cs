using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Math math = new Math();
			int result = 0;

			Console.Write("Please enter a number: ");
			int userInput = Convert.ToInt32((string)Console.ReadLine());

			math.Divide(userInput);
			Console.ReadLine();

			result = math.Divide();
			Console.ReadLine();

			StaticClass.Divide(userInput, result);
		}
	}
}
