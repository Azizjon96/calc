using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
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
                default:
                   throw new Exception("Неизвестная операция!");
            }

        }
    }
}
