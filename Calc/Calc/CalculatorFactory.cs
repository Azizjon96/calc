using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class CalculatorFactory
    {
        public ICalculate CreateCalcuator(string name) 
        {
            switch (name)
            {
                case "button1":
                  return new Addition; // result = first + second;
                    break;
                case "button2":
                 return new   //result = first - second;
                    break;
                case "button3":
                    result = first * second;
                    break;
                case "button4":
                    result = first / second;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
