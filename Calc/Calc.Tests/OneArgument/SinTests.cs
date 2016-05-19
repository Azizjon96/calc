using System;
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
  public   class SinTests
    {
        [TestCase((Math.PI / 6),0.5)]
        public void SinTest(double first, double expected)
        {
            IoneCalculate calc = new Sin();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result,0.001);
        }
    }
}
