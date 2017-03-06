using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.TableOfTolerancesAndFits
{
    public class NominalSizeRangeAndTolerance
    {
        public Interval nominalSizeRange { get; set; }
        public double tolerance { get; set; }

        public bool checkIterval(double size)
        {
            return nominalSizeRange.checkOfInterval(size);
        }

        public double getTolerance()
        {
            return this.tolerance;
        }
    }
}
