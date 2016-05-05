
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
        double result = calc.Calculate(90);
        Assert.AreEqual(0, result);
    }
    }

}
