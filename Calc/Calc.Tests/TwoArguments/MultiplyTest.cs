using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
   public  class MultiplyTest
    {
    [Test]
        public void SimpleTest()
        {
            ICalculate calc = new Multiply();
            double result = calc.Calculate(2, 3);
            Assert.AreEqual(6, result);
        }
    }

}
