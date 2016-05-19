
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
    public class FactorialTests
    {
        [TestCase(5, 120)]
        [TestCase(8,40320 )]
        [TestCase(4, 24)]
        public void FacTest(double first, double expected)
        {
            IoneCalculate calc = new Factorial();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }

    }
}
