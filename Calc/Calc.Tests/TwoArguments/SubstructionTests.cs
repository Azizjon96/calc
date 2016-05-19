using Calc.TwoArguments;
using NUnit.Framework;

namespace Calc.Tests.TwoArguments
{
    [TestFixture]
   public class SubstructionTests
    {
        [TestCase(20, 3, 17)]
        [TestCase(30, 3, 27)]
        public void SubsTest(double first, double second, double expected)
       {
           ICalculate calc = new Substruction();
           double result = calc.Calculate(first,second);
           Assert.AreEqual(expected, result);
       }

    }
}
