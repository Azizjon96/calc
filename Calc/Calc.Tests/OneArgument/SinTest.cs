using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.OneArgument;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
  public   class SinTest
    {
        [Test]
        public void SimpleTest()
        {
            IoneCalculate calc = new Sin();
            double result = Math.Round(calc.Calculate(Math.PI / 6), 3);
            Assert.AreEqual(0.5, result);
        }
    }
}
