using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            int secondNumber = 0;
            Console.WriteLine("Please enter two numbers one at a time. The second one you can leave blank:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            string secondInput = Console.ReadLine();

            // Can't convert an empty string to int so confirming it has a value before utilizing the conversion
            if (secondInput.Length != 0)
            {
                secondNumber = Convert.ToInt32(secondInput);
            }

            Console.WriteLine(math.DoubleTrouble(firstNumber));
            Console.ReadLine();
        }
    }
}
