using System;
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
    public class TgTests
    {
        [TestCase((Math.PI / 4), 1)]
        public void TgTest(double first, double expected)
        {
            IoneCalculate calc = new tg();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected , result, 0.001);
        }
    }
}
