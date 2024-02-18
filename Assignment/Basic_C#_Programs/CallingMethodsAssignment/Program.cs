using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to do calculations with");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Digit digit = new Digit();

            Console.WriteLine(digit.Multiply(userNumber));
            Console.WriteLine(digit.Divide(userNumber));
            Console.WriteLine(digit.Add(userNumber));

            Console.ReadLine();
        }
    }
}
