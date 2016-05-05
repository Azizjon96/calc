
using System;
using Calc.OneArgument;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calc.Tests.OneArgument
{
[TestFixture]
   public class CtgTest
    {
    
    [Test]
    public void SimpleTest()
    {

        IoneCalculate calc = new Ctg();
        double result =Math.Round(calc.Calculate(Math.PI/2),3) ;
        Assert.AreEqual(0, result);
    }
    }

}
