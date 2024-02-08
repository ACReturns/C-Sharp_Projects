using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.WriteLine("Person 1:\n");

            Console.WriteLine("Hourly Rate?");
            string person1_HourlyRate = Console.ReadLine();
            Console.WriteLine("Hourly Rate: $" + person1_HourlyRate);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string person1_HoursWorked = Console.ReadLine();
            Console.WriteLine("Hours worked per week: " + person1_HoursWorked);
            Console.ReadLine();

            Console.WriteLine("Person 2:\n");

            Console.WriteLine("Hourly Rate?");
            string person2_HourlyRate = Console.ReadLine();
            Console.WriteLine("Hourly Rate: $" + person2_HourlyRate);
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");
            string person2_HoursWorked = Console.ReadLine();
            Console.WriteLine("Hours worked per week: " + person2_HoursWorked);
            Console.ReadLine();

            decimal person1_AnnualSalary = Convert.ToInt64(person1_HourlyRate) * Convert.ToInt64(person1_HoursWorked) * 52;
            decimal person2_AnnualSalary = Convert.ToInt64(person2_HourlyRate) * Convert.ToInt64(person2_HoursWorked) * 52;
            bool whoEarnsMore = person1_AnnualSalary > person2_AnnualSalary;

            Console.WriteLine("Annual salary of Person 1: " + person1_AnnualSalary);
            Console.WriteLine("Annual salary of Person 2: " + person2_AnnualSalary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + whoEarnsMore);
            Console.ReadLine();
        }
    }
}
