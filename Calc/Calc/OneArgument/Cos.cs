using System;

namespace Calc.OneArgument
{
    public class Cos : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
