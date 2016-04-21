using System;

namespace Calc.TwoArguments
{
    public static class CalculatorFactory
    {
        public static ICalculate CreateCalcuator(string name) 
        {
            switch (name)
            {
                case "button1":
                  return new Addition(); // result = first + second;
                case "button2":
                 return new Substruction();   //result = first - second;
                case "button3":
                    return new Multiply();
                case "button4":
                    return new Division();
             default:
                    throw new Exception("Неизвестная операция!");
            }
        }
    }
}
