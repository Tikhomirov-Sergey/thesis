﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.CurvatureOfImpressionDieForgings
{
    public class IntervalAndCoefficient
    {
        public Interval estimatedSize { get; set; }
        public double coefficient { get; set; }

        public double getCoefficient()
        {
            return coefficient;
        }

        public bool checkOfSize(double requiredSize)
        {
            return estimatedSize.checkOfInterval(requiredSize);
        }
    }
}
