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
   public   class tgTest
    {
    [Test]
        public void SimpleTest()
        {
            IoneCalculate calc = new tg();
            double result = calc.Calculate(90);
            Assert.AreEqual(0, result);
        }
    }
}
