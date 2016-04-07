using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Factorial: IoneCalculate
    {
        public double Calculate(double first)
        {
            if (first <= 1)
            {
                return 1;
            }
            return first * Calculate(first - 1);
            }
    
    }
}
