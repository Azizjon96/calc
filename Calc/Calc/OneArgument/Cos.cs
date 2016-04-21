using System;

namespace Calc.OneArgument
{
    internal class Cos : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
