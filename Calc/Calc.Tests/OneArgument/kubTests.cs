using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
    public class KubTests
    {
        [TestCase(2, 8)]
        [TestCase(3, 27)]
        [TestCase(5,125)]
        [TestCase(4, 64)]
        public void KubTest(double first, double expected)
        {
            IoneCalculate calc = new kub();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
