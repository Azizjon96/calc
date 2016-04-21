using System;

namespace Calc.OneArgument
{
   public class Sin: IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    
    }
}
