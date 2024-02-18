using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.DoMath(25));
            Console.ReadLine();

            Console.WriteLine(math.DoMath(22.5m));
            Console.ReadLine();

            Console.WriteLine(math.DoMath("35"));
            Console.ReadLine();
        }
    }
}
