﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class sqrt : IoneCalculate
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}