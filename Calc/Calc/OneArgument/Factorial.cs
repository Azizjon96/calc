namespace Calc.OneArgument
{
  public class Factorial: IoneCalculate
    {
        public double Calculate(double first)
        {
            if (first <= 1)
            {
                return 1;
            }
            return first * Calculate(first - 1);
            }
    
    }
}
