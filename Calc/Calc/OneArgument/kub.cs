using System;

namespace Calc.OneArgument
{
    public class kub: IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,3);
        }
    }
}
