using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("Student Name: " + studentName);

            Console.WriteLine("What course are you in?");
            string CourseName = Console.ReadLine();
            Console.WriteLine("Tech Academy Course: " + CourseName);

            Console.WriteLine("What page number?");
            string getPage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(getPage);
            Console.WriteLine("Student is on page " + pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // To ensure the if statement isnt thrown off if a capital is used we lowercase everything
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "true" || userResponse == "false")
            {
                bool needHelp = Convert.ToBoolean(userResponse);
                Console.WriteLine("Did student need help: " + needHelp);
            }
            else
            {
                Console.WriteLine("\"" + userResponse + "\" does not equal true or false");
                Console.ReadLine();
            }

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string expResponse = Console.ReadLine();
            Console.WriteLine("Shared Experience: " + expResponse);

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedbackResponse = Console.ReadLine();
            Console.WriteLine("User Response: " + feedbackResponse);

            Console.WriteLine("How many hours did you study?");
            string studyHours = Console.ReadLine();
            int totalHours = Convert.ToInt32(studyHours);
            Console.WriteLine(totalHours + " hours studied");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
