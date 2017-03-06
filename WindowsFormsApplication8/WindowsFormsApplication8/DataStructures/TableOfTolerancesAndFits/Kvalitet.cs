using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.TableOfTolerancesAndFits
{
    public class Kvalitet
    {
        public double kvalitet  { get; set; }
        public NominalSizeRangeAndTolerance[] nominalSizeRangeAndTolerance { get; set; }

        public bool checkKvalitet(double kvalitet)
        {
            return this.kvalitet == kvalitet;
        }

        public double getTolerance(double size)
        {
            foreach(NominalSizeRangeAndTolerance nominalSizeRange in nominalSizeRangeAndTolerance)
            {
                if (nominalSizeRange.checkIterval(size))
                {
                    return nominalSizeRange.getTolerance();
                }
            }
            return 0;
        }
    }
}
