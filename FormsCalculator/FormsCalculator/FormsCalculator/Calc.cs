﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCalculator
{
    public static class Calc
    {
        public static double GetTax(double d)
        {
            return Math.Floor(d * 1.08);
        }
    }
}
