using System;

namespace Calc.OneArgument
{
    public static class SingleCalcFactory
    {
        public static IoneCalculate CreateCalcuator(string name)
        {
            switch (name)
            {
                case "button5":
                    return new sqr();
                case "button6":
                    return new sqrt();
                case "button7":
                    return new Sin();
                case "button11":
                    return new kub();
                case "button8":
                    return new Cos();
                case "button9":
                    return new tg();
                case "button10":
                    return new Ctg();
                case "button12":
                    return new Factorial();
                default:
                   throw new Exception("Неизвестная операция!");
            }

        }
    }
}
