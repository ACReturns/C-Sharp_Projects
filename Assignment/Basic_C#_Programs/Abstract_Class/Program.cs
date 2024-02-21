using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee() { FirstName = "Sample", LastName = "Student"};
			employee.SayName();

			IQuittable employee2 = new Employee();
			employee2.Quit();

			Employee employee3 = new Employee() { FirstName = "Sample", LastName = "Student", EmployeeID = 1 };
			Employee employee4 = new Employee() { FirstName = "Sample", LastName = "Student", EmployeeID = 1 };

			if(employee3.EmployeeID == employee4.EmployeeID)
			{
				Console.WriteLine("Employee IDs are the same");
				Console.ReadLine();
			}
		}
	}
}
