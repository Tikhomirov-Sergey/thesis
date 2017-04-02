using System;

namespace WindowsFormsApplication8
{
    class Rounding
    {
        public static double rounding(double value, int digits = 5)
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
