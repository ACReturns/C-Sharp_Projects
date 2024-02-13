using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("What is your package weight?");
            string packageWeight = Console.ReadLine();
            int pkgWeight = Convert.ToInt32(packageWeight);
            int maxLimit = 50;

            if (pkgWeight > maxLimit)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What is your package width?");
            string packageWidth = Console.ReadLine();
            int pkgWidth = Convert.ToInt32(packageWidth);

            Console.WriteLine("What is your package height?");
            string packageHeight = Console.ReadLine();
            int pkgHeight = Convert.ToInt32(packageHeight);

            Console.WriteLine("What is your package length?");
            string packageLength = Console.ReadLine();
            int pkgLength = Convert.ToInt32(packageLength);

            if ((pkgWidth + pkgHeight + pkgLength) > maxLimit)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            decimal pkgQuote = (pkgLength * pkgHeight * pkgWidth) * pkgWeight / 100;
            Console.WriteLine("Your estimated total for shipping this package is $" + pkgQuote);

            Console.ReadLine();
        }
    }
}
