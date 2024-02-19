using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
	public class Employee : Person, IQuittable
	{
		public void Quit()
		{
			Console.WriteLine("Putting in my 2 weeks notice");
			Console.ReadLine();
		}

		public override void SayName()
		{
			base.SayName();
		}
	}
}
