using System;

namespace WindowsFormsApplication8
{
    class Rounding
    {
        public static double rounding(double value, double tolerance)
        {
            try
            {
                int digits = getDigits(tolerance);

                value = Math.Round(value, digits);
            }
            catch { }

            return value;
        }

        private static int getDigits(double tolerance)
        {
            string strTolerance = tolerance.ToString();

            int length = strTolerance.Length;
            int indexComma = strTolerance.IndexOf(',');

            int digits;

            if (indexComma == -1)
            {
                digits = 0;
            }
            else
            {
                digits = length - indexComma - 1;
            }

            return digits;
        }
    }
}
