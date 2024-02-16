using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptionHandling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                List<int> savedNumbers = new List<int>() { 3, 15, 7, 9, 10 };
                Console.WriteLine("Please enter a number to divide 5 numbers by.");
                int userNumber = Convert.ToInt32((string)Console.ReadLine());

                foreach (int number in savedNumbers)
                {
                    int numberResult = number / userNumber;
                    Console.WriteLine(number + " divided by " + userNumber + " equals " + numberResult);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You attempted to divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Try/ Catch process has completed.");
                Console.ReadLine();
            }
        }
    }
}