using System;

namespace Calc.OneArgument
{
    class sqrt : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
