using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionTest
    {
        [TestCase(2, 3, 5)]
        [TestCase(3, 3, 6)]
        public void AddTest(double first, double second, double expected)
        {
            ICalculate calc = new Addition();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
