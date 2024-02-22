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

			
			Console.WriteLine(employee3.EmployeeID == employee4.EmployeeID);
			Console.ReadLine();
			

			Employee<string> employee5 = new Employee<string>();
			employee5.things = new List<string>() { "Apple", "Snapple", "Crackle", "Pop" }; 

			Employee<int> employee6 = new Employee<int>();
			employee6.things = new List<int>() { 2, 4, 6, 9 };

			foreach(string stringThing in employee5.things)
			{
				Console.WriteLine("First we have the string " + stringThing);
			}
			foreach (int intThing in employee6.things)
			{
				Console.WriteLine("Then we have the number " + intThing);
			}
			Console.ReadLine();
		}
	}
}
