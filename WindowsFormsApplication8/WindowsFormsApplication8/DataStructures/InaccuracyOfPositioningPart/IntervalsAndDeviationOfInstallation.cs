using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStuctures.InaccuracyOfPositioningPart
{
   public class IntervalsAndDeviationOfInstallation
    {
        public DataStructures.Interval intervalOfSize { get; set; }
        public double deviationOfInstallation { get; set; }

        public bool chekInterval(double requiredSize)
        {
            return this.intervalOfSize.checkOfInterval(requiredSize);
        }

        public double getDeviationOfInstallation()
        {
            return this.deviationOfInstallation;
        }
    }
}
