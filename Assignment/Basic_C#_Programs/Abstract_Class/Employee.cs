using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
	public class Employee : Person, IQuittable
	{
		public int EmployeeID { get; set; }

		public void Quit()
		{
			Console.WriteLine("Putting in my 2 weeks notice");
			Console.ReadLine();
		}

		public override void SayName()
		{
			Console.WriteLine("Name: {0} {1}", FirstName, LastName);
			Console.ReadLine();
		}

		public static bool operator ==(Employee a, Employee b)
		{
			bool EmployeeEqual = a.EmployeeID.Equals(b.EmployeeID);
			return EmployeeEqual;
		}

		public static bool operator!= (Employee a, Employee b)
		{
			bool EmployeeEqual = !a.EmployeeID.Equals(b.EmployeeID);
			return EmployeeEqual;
		}
	}
}
