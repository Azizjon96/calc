
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
  public  class SqrtTests
    {
        [TestCase(36,6)]
        public void SqrtTest(double first, double expected)
        {
            IoneCalculate calc = new sqrt();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
