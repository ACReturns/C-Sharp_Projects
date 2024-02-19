using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Math
    {
        public void Divide(out int result, int value)
        {
            result = value / 2;
            Console.WriteLine(value + " / " + 2 + " = " + result);
        }

        public int Divide(int value1, int value2)
        {
            Console.WriteLine(value1 + " / " + value2 + " = ");
            return value1 / value2;
        }
    }
}
