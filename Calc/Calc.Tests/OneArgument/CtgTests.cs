
using System;
using Calc.OneArgument;
using NUnit.Framework;


namespace Calc.Tests.OneArgument
{
[TestFixture]
   public class CtgTests
    {

    [TestCase((Math.PI / 2),0)]
    public void CtgTest(double first, double expected)
    {

        IoneCalculate calc = new Ctg();
        double result = calc.Calculate(first); 
        Assert.AreEqual(expected, result,0.001);
    }
    }

}
