using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int result = 0;

            Console.Write("Please enter a number: ");
            int userInput = Convert.ToInt32((string)Console.ReadLine());

            math.Divide(out result, userInput);
            Console.ReadLine();

            result = math.Divide(userInput, result);
            Console.WriteLine(result);
            Console.ReadLine();

            var decimalResult = Divide(userInput, result);
            Console.WriteLine(userInput + " / " + result + " = " + decimalResult);
            Console.ReadLine();
        }

        public static decimal Divide(decimal value1, decimal value2)
        {
            return value1 / value2; ;
        }
    }
}
