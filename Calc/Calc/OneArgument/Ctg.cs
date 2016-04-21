using System;

namespace Calc.OneArgument
{
   public  class Ctg : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Cos(first) / Math.Sin(first);
        }
    
    }
}
