using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Do/ While loop
            Console.WriteLine("Hello, what's the name on your reservation?");
            string reserveName = Console.ReadLine();
            bool hotelCheckIn = reserveName == "Stanley";

            do
            {
                switch(reserveName) 
                {
                    case "Chief":
                        Console.WriteLine("Unfortunately I don't have a reservation for the Chiefs, please make a reservation as we are booked today\n");
                        Console.WriteLine("Hello, what's the name on your reservation?");
                        reserveName = Console.ReadLine();
                        break;
                    case "Williams":
                        Console.WriteLine("It looks like your reservation is for tomorrow. Come back tomorrow to gain access to your room.\n");
                        Console.WriteLine("Hello, what's the name on your reservation?");
                        reserveName = Console.ReadLine();
                        break;
                    case "Stanley":
                        Console.WriteLine("Welcome! We have you on the 3rd floor, someone will help you with your bags.\n");
                        hotelCheckIn = true;
                        break;
                    default:
                        Console.WriteLine("I'm sorry... I don't see you in our system. Please make a reservation next time and we can take care of you!\n");
                        Console.WriteLine("Hello, what's the name on your reservation?");
                        reserveName= Console.ReadLine();
                        break;
                }
            }
            while ( !hotelCheckIn );

            // While Loop
            Console.WriteLine("How many students are in your class?");
            int totalStudents = Convert.ToInt32(Console.ReadLine());
            int headCount = 0;
            
            Console.WriteLine("Lets get a headcount to make sure we have all of the students in class...");
            Console.ReadLine();
            
            while (headCount != totalStudents)
            {
                headCount++;
                Console.WriteLine(headCount);
            }

            Console.WriteLine("Looks like everyone is here!");
            Console.ReadLine();
        }
    }
}
