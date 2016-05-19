
using Calc.TwoArguments;
using NUnit.Framework;
namespace Calc.Tests.TwoArguments
{
    [TestFixture] 
  public   class DivisionTests
    {
        [TestCase(100, 2, 50)]
        [TestCase(3, 3, 1)]
        [TestCase(3,2,1.5)]
        public void DivTest(double first, double second, double expected)
        {
            ICalculate calc = new Division();
            double result = calc.Calculate(first,second);
            Assert.AreEqual(expected, result);
        }
    }
}
