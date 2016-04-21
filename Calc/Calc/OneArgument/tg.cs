using System;

namespace Calc.OneArgument
{
   public class tg : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first) / Math.Cos(first);
        }
    }
}
