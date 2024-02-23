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

			
			Console.WriteLine(employee3 == employee4);
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

			Employee employee_1 = new Employee() { FirstName = "Viviana", LastName = "Cerda", EmployeeID = 1 };
			Employee employee_2 = new Employee() { FirstName = "Jermaine", LastName = "Staten", EmployeeID = 2 };
			Employee employee_3 = new Employee() { FirstName = "Garlic", LastName = "Junior", EmployeeID = 55 };
			Employee employee_4 = new Employee() { FirstName = "Joe", LastName = "Shmoh", EmployeeID = 14 };
			Employee employee_5 = new Employee() { FirstName = "Ryan", LastName = "Apple", EmployeeID = 9 };
			Employee employee_6 = new Employee() { FirstName = "Reggie", LastName = "Bottom", EmployeeID = 3 };
			Employee employee_7 = new Employee() { FirstName = "Cecilia", LastName = "Genes", EmployeeID = 8 };
			Employee employee_8 = new Employee() { FirstName = "Joe", LastName = "Smith", EmployeeID = 31 };
			Employee employee_9 = new Employee() { FirstName = "Bianca", LastName = "Paz", EmployeeID = 4 };
			Employee employee_10 = new Employee() { FirstName = "Ham", LastName = "Taro", EmployeeID = 0 };

			List<Employee> newHires = new List<Employee>() { employee_1 , employee_2, employee_3, employee_4, employee_5, 
				employee_6, employee_7, employee_8, employee_9, employee_10 };


			List<Employee> onlyJoe = new List<Employee>();

			foreach (var hire in newHires)
			{
				if (hire.FirstName == "Joe")
				{
					onlyJoe.Add(hire);
				}
			}

			Console.WriteLine("The amount of hires with the name Joe are " + onlyJoe.Count());
			Console.ReadLine();

			List<Employee> justJoe = newHires.Where(x => x.FirstName == "Joe").ToList();

			Console.WriteLine("The amount of hires with the name Joe are " + justJoe.Count());
			Console.ReadLine();

			List<Employee> highID = newHires.Where(x => x.EmployeeID > 5).ToList();

			Console.WriteLine("The number of employee IDs that are higher than 5 are " + highID.Count());
			Console.ReadLine();
		}
	}
}
