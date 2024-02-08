using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovalProgram
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            Console.WriteLine("Users Age: " + userAge);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? (true or false)");
            string userResponse = Console.ReadLine();
            bool duiResult;
            Console.WriteLine("User Response: " + userResponse);
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string userTickets = Console.ReadLine();
            Console.WriteLine("User has had " + userTickets + " speeding tickets");
            Console.ReadLine();

            bool userQuailified = Convert.ToInt64(userAge) > 15 && Boolean.TryParse(userResponse, out duiResult) == true && 
                Convert.ToInt64(userTickets) < 3;

            Console.WriteLine("User quailified for car insurance? " + userQuailified);
            Console.ReadLine();
        }
    }
}
