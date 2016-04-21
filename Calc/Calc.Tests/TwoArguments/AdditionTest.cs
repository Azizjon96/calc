using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]
        public void SimpleTest()
        {
            ICalculate calc = new Addition();
            double result = calc.Calculate(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
