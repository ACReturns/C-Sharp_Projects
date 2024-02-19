using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class Math
    {
        public int DoMath(int value)
        {
            return value + 13;
        }

        public int DoMath(decimal value) 
        {
            return Convert.ToInt32(value * 22);
        }

        public int DoMath(string value)
        {
            return Convert.ToInt32(value)/3;
        }
    }
}
