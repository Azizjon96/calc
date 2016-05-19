
using System;
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
   public class CosTests
    {
        [TestCase((Math.PI/2),0)]
        public void CosTest(double first, double expected)
        {
            IoneCalculate calc = new Cos(); 
            double result = calc.Calculate(first);
            Assert.AreEqual(expected , result, 0.001);
        }
    }

    
}
