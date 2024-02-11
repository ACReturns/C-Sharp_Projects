using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAssignment
{
    internal class Program
    {
        static void Main()
        {
            string[] comicHeroes = { "Cyclops", "Captain America", "Ironman", "Hulk", "Wolverine", "Phoenix"};
            Console.WriteLine("Enter an index to see your hero! [0 - 5]");
            int heroIndex = Convert.ToInt32(Console.ReadLine());

            // Checks if the index is less than the length, if so then the index exist
            if (heroIndex < comicHeroes.Length)
            {
                Console.WriteLine("You selected " + comicHeroes[heroIndex]);
            }
            else
            {
                Console.WriteLine("There is no hero in that index");
            }
            Console.ReadLine();


            int[] comicIssues = { 1, 30, 21, 100, 13, 7 };
            Console.WriteLine("What is your favorite comic issue? [0 - 5]");
            int issueIndex = Convert.ToInt32(Console.ReadLine());

            // Checks if the index is greater than the length of the array, if so then it doesn't exist
            if (issueIndex > comicIssues.Length)
            {
                Console.WriteLine("There is no comic issue in that index");
            }
            else
            {
                Console.WriteLine("You selected issue number #" + comicIssues[issueIndex]);
            }
            Console.ReadLine();


            List<string> seriesNames = new List<string> { "X-Men", "Daredevil", "Fantastic Four", "Deadpool", "Civil War" };
            Console.WriteLine("Please enter an index for a series you enjoy reading/ watching: [0 - 4]");
            int seriesIndex = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You selected " + seriesNames[seriesIndex]);
            Console.ReadLine();
        }
    }
}
