using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main()
        {
            // Part 1
            string[] fruitNames = new string[] { "coconut", "orange", "banana", "apple", "pumpkin" };

            Console.WriteLine("Please enter your favorite flavor");
            string userBrand = Console.ReadLine();

            for (int i = 0; i < fruitNames.Length; i++)
            {
                if (i < fruitNames.Length)
                {
                    fruitNames[i] = fruitNames[i] + " " + userBrand;
                    Console.WriteLine(fruitNames[i]);
                }
            }
            Console.WriteLine("Part 1 Completed");
            Console.ReadLine();

            // Part 2
            bool spamBug = true;
            while (spamBug)
            {
                Console.WriteLine("Snail exists");
                spamBug = false;
            }

            Console.WriteLine("Part 2 Completed");
            Console.ReadLine();

            // Part 3
            int[] numCount = { 1, 5, 9, 7, 10 };
            if (0 < numCount.Length)
            {
                Console.WriteLine("The number count is: " + numCount.Length);
            }

            if (4 <= numCount.Length)
            {
                Console.WriteLine("The number is less than or equal");
            }

            Console.WriteLine("Part 3 Completed");
            Console.ReadLine();

            // Part 4
            List<string> fastFood = new List<string>() { "fries", "burger", "chili", "sandwich", "shake", "soda" };
            Console.WriteLine("What would you like to order to eat?");
            string userOrder = Console.ReadLine().ToLower();

            foreach (var food in fastFood)
            {
                if (food == userOrder)
                {
                    Console.WriteLine("You ordered a " + food);
                    break;
                }

                if (food == fastFood.LastOrDefault() && food != userOrder)
                {
                    Console.WriteLine("It looks like you ordered something not on the menu");
                }
            }

            Console.WriteLine("Part 4 Completed");
            Console.ReadLine();

            // Part 5
            List<string> attireList = new List<string>() { "hat", "tie", "watch", "jacket", "tie" };
            Console.WriteLine("What would you like to wear today?");
            string userThreads = Console.ReadLine().ToLower();

            for (int i = 0; i < attireList.Count; i++)
            {
                if (userThreads == attireList[i].ToString())
                {
                    Console.WriteLine("The index for " + attireList[i] + " is " + i);
                    break;
                }
                else if (!attireList.Contains(userThreads))
                {
                    Console.WriteLine(userThreads + " doesn't exist in the list");
                    break;
                }
            }
            Console.WriteLine("Part 5 Completed");
            Console.ReadLine();

            // Part 6
            List<string> animals = new List<string>() { "cow", "cat", "dog", "cow", "dog" };
            List<string> animalExists = new List<string>();

            foreach (string animal in animals)
            {
                if (!animalExists.Contains(animal))
                {
                    animalExists.Add(animal);
                    Console.WriteLine(animal);
                }
                else
                {
                    Console.WriteLine(animal + " already exists in the list");
                }
            }
            Console.WriteLine("Part 6 Completed");
            Console.ReadLine();
        }
    }
}

