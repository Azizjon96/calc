using System;

namespace Calc.OneArgument
{
    class Ctg : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first) / Math.Sin(first);
        }
    
    }
}
