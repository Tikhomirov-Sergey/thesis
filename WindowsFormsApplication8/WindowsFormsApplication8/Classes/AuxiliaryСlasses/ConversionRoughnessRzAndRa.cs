using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class ConversionRoughnessRzAndRa
    {
        public static double RzToRa(double rz)
        {
             double ra = rz / 0.004;
             return ra;
        }

        public static double RaToRz(double ra)
        {
            double rz = ra * 0.004;
            return rz;
        }

        public static Interval intervalRzToIntervalRa(Interval intervalRz)
        {
            double minRz = intervalRz.getIntervalMin();
            double maxRz = intervalRz.getIntervalMax();

            double minRa = RzToRa(minRz);
            double maxRa = RzToRa(maxRz);

            Interval intervalRa = new Interval(minRa, maxRa);

            return intervalRa;
        }

        public static Interval intervalRaToIntervalRz(Interval intervalRa)
        {
            double minRa = intervalRa.getIntervalMin();
            double maxRa = intervalRa.getIntervalMax();

            double minRz = RaToRz(minRa);
            double maxRz = RaToRz(maxRa);

            Interval intervalRz = new Interval(minRz, maxRz);

            return intervalRz;
        }

        public static string stringRaToRz(string ra)
        {
            double raDouble = Convert.ToDouble(ra);
            double rz = RaToRz(raDouble);
            string rzString = Convert.ToString(rz);
            return rzString;
        }

        public static string stringRzToRa(string rz)
        {
            double rzDouble = Convert.ToDouble(rz);
            double ra = RzToRa(rzDouble);
            string raString = Convert.ToString(ra);
            return raString;
        }
    }
}
