using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class kub: IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,3);
        }
    }
}
