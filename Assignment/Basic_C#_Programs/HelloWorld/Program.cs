using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your name? ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hi " + yourName);
            Console.ReadLine();

            Console.WriteLine("Give me a number:");
            string inputNumber = Console.ReadLine();
            int convertNumber = Convert.ToInt32(inputNumber);
            int total = convertNumber + 10;
            Console.WriteLine("Your number plus 10 equals " + total);
            Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103'; // this is a question mark
            decimal moneyInBank = 100.5m; // decimals require m at the end of the number
            double heightInCentimeters = 211.30202092;
            float secondsLeft = 2.62f; // floats require f at the end of the number
            short temperatureOnMars = -341;
        }
    }
}
