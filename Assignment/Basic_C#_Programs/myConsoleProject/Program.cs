using System;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Collections.Generic;

namespace myConsoleProject
{
    internal class Program
    {
        static void Main()
        {
            /*Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();*/

            /*  int num1 = 200 / 3;
              Console.WriteLine(num1);
              Console.ReadLine();*/

            /*Console.WriteLine("Enter number:");
            Console.Read();
            string response = Console.ReadLine();
            int multiply = Convert.ToInt32(response) * 50; 
            Console.WriteLine(response + " * 50 = " + multiply);
            Console.ReadLine();*/

            // XOR Operator is '^' which will equal true if one of the options are true
            /*int currentTemp = 70;
            int roomTemp = 70;

            string result = currentTemp > roomTemp ? "It''s getting pretty hot" : "Nah, it feels great!";
            Console.WriteLine(result);
            Console.ReadLine();*/

            // Do/ While loop
            /*Console.WriteLine("Guess a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62, try again\n");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29, try again\n");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12, good job!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You guessed the wrong number\n");
                        Console.WriteLine("Guess a number:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            
            Console.ReadLine();*/

            // Strings / String builder
            /*string fName = "Don";
            string mName = "Russell";
            string lName = "Smith";

            string fullName = string.Concat(fName, mName, lName);
            Console.WriteLine(fullName);
            Console.ReadLine();

            string lowerCase = "paul phoenix";
            Console.WriteLine(lowerCase.ToUpper());
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(fullName);
            sb.AppendLine(lowerCase);
            sb.AppendLine("3 lines created with a string builder!");

            Console.WriteLine(sb);
            Console.ReadLine();*/

            // Arrays & Lists
            /*int[] numArray = new int[5]; // You need to declare a size when you make a new array
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; // Does the same as above and cleaner if you know what will be inside

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            numArray2[5] = 650; // This lets you target and edit the specific part in the array
            // Arrays are set to the size you create it at

            Console.WriteLine(numArray[3]);
            Console.ReadLine();*/

            /*List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);

            Console.WriteLine(intList[1]);
            Console.ReadLine();

            byte[] byteArray = new byte[1024];*/

            // Iteration
            /*int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for(int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();*/

            /*string[] names = { "Paul", "Law", "King", "Kazuya", "Nina", "Anna", "Jin", "Wang", "Heihachi" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Heihachi")
                {
                    Console.WriteLine(names[j] + " Mishima... is dead...");
                }
                else
                {
                    Console.WriteLine(names[j]);
                }
            }
            Console.ReadLine();*/

            /*List<int> testScores = new List<int>();
            testScores.Add(98);
            testScores.Add(90);
            testScores.Add(85);
            testScores.Add(70);
            testScores.Add(82);
            testScores.Add(32);
            testScores.Add(20);
            testScores.Add(94);

            foreach (int score in testScores) 
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }
            Console.ReadLine();*/

            /*List<string> names = new List<string>() { "Paul", "Law", "King", "Kazuya", "Nina", "Anna", "Jin", "Wang", "Heihachi" }; 

            foreach (string name in names)
            {
                if (name == "Heihachi")
                {
                    Console.WriteLine(name + " Mishima... is dead...");
                }
                else
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();*/

            List<int> testScores = new List<int>() { 99, 98, 12, 75, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores) 
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
