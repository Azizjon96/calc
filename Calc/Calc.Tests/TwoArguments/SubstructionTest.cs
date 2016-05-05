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
   public class SubstructionTest
    {
       [Test]
       public void SimpleTest()
       {
           ICalculate calc = new Substruction();
           double result = calc.Calculate(2, 3);
           Assert.AreEqual(-1, result);
       }

    }
}
