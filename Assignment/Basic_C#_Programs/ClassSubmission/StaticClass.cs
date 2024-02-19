using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
	public static class StaticClass
	{
		public static void Divide(decimal value1, decimal value2)
		{
			decimal result = value1 / value2;
			Console.WriteLine(value1 + " / " + value2 + " = " + result);
			Console.ReadLine();
		}
	}
}
