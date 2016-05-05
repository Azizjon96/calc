using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
   public  class MultiplyTest
    {
        [TestCase(20, 3, 60)]
        [TestCase(30, 3, 90)]
        public void AddTest(double first, double second, double expected)
        {
            ICalculate calc = new Multiply();
            double result = calc.Calculate(first,second);
            Assert.AreEqual(expected, result);
        }
    }

}
