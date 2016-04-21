using System;

namespace Calc.OneArgument
{
    class kub: IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,3);
        }
    }
}
