using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.TwoArguments;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc.Tests.TwoArguments
{
    [TestFixture] 
  public   class DivisionTest
    {
        [Test]
        public void SimpleTest()
        {
            ICalculate calc = new Division();
            double result = calc.Calculate(6, 3);
            Assert.AreEqual(2, result);
        }
    }
}
