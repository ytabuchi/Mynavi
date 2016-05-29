using System;

namespace NativeCalculator
{
    public static class Calc
    {
        public static double GetTax(double d)
        {
            return Math.Floor(d * 1.08);
        }
    }
}

