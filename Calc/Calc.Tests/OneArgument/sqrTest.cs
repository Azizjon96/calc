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
   public  class sqrTest
    {
        [Test]
        public void SimpleTest()
        {
            IoneCalculate calc = new sqr();
            double result = calc.Calculate(5);
            Assert.AreEqual(25, result);
        }
    }
}
