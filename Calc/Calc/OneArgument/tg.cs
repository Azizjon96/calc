using System;

namespace Calc.OneArgument
{
    class tg : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first) / Math.Cos(first);
        }
    }
}
