using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.TableOfTolerancesAndFits
{
    public class Interval
    {
        public double min { get; set; }
        public double max { get; set; }
        
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
    }
}
