﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Sin: IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    
    }
}
