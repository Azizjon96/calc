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
  public  class KubTest
    {
        [Test]
        public void SimpleTest()
        {
            IoneCalculate calc = new kub();
            double result = calc.Calculate(2);
            Assert.AreEqual(8, result);
        }
    }
}
