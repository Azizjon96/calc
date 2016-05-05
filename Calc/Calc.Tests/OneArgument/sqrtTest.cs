using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests.OneArgument
{
    [TestFixture]
  public  class sqrtTest
    {
        [Test]
        public void SimpleTest()
        {
            IoneCalculate calc = new sqrt();
            double result = calc.Calculate(36);
            Assert.AreEqual(6, result);
        }
    }
}
