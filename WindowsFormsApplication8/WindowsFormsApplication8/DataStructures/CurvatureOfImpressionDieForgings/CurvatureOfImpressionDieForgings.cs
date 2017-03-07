using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class CurvatureOfImpressionDieForgings
    {
       public DataStructures.CurvatureOfImpressionDieForgings.IntervalAndCoefficient[] intervalAndCoefficient { get; set; }

        public double getCoefficient(double requiredSize)
        {
            foreach (DataStructures.CurvatureOfImpressionDieForgings.IntervalAndCoefficient intervalAndCoefficient in this.intervalAndCoefficient)
            {
                if (intervalAndCoefficient.checkOfSize(requiredSize))
                {
                    return intervalAndCoefficient.coefficient;
                }
            }
            return 0;
        }
    }
}
