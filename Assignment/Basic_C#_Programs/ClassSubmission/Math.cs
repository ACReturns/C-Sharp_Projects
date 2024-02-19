using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Math
    {
        public void Divide(int value)
        {
            int result = value / 2;
            Console.WriteLine(value + " / " + 2 + " = " + result);
        }

        public int Divide()
        {
            int result = 100 / 10;
            Console.WriteLine("100 / 10 = " + result);
            return result;
        }
    }
}
