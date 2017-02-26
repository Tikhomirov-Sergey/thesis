using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Interval
    {
        private double min;
        private double max;

        public Interval(double min, double max)
        {
            this.min = min;
            this.max = max;
        }

        public bool checkOfInterval(double value)
        {
            return ((this.min < value) && (this.max > value));
        }

        public double getIntervalMin()
        {
            return this.min;
        }

        public double getIntervalMax()
        {
            return this.max;
        }

        public string getIntervalMinConvertToString()
        {
            string min = Convert.ToString(this.min);
            return min;
        }

        public string getIntervalMaxConvertToString()
        {
            string max = Convert.ToString(this.max);
            return max;
        }

        public static bool CheckOfInterval(double min, double max, double value)
        {
            Interval interval = new Interval(min, max);
            return interval.checkOfInterval(value);
        }
    }
}
