
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture] 
   public  class SqrTests
    {
        [TestCase(5,25)]
        public void SqrTest(double first, double expected)
        {
            IoneCalculate calc = new sqr();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
