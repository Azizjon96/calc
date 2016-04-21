using System;

namespace Calc.OneArgument
{
    class Sin: IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    
    }
}
