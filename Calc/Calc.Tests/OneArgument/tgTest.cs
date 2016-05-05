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
            double result = Math.Round(calc.Calculate(Math.PI / 4), 3);
            Assert.AreEqual(1, result);
        }
    }
}
