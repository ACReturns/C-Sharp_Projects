using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Number numRef = new Number();
			numRef.Amount = 25;
			Console.WriteLine(numRef.Amount);
			Console.ReadLine();
		}
	}
}
