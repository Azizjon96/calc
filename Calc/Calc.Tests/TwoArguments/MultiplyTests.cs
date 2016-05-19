using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
   public  class MultiplyTests
    {
        [TestCase(20, 3, 60)]
        [TestCase(30, 3, 90)]
        public void MultTest(double first, double second, double expected)
        {
            ICalculate calc = new Multiply();
            double result = calc.Calculate(first,second);
            Assert.AreEqual(expected, result);
        }
    }

}
