using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Rounding
    {
        public static double rounding(double value, int digits = 3)
        {
            try
            {
                value = Math.Round(value, digits);
            }
            catch { }

            return value;
        }
    }
}
