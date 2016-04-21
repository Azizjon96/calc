using System;

namespace Calc.OneArgument
{
   public class sqrt : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
