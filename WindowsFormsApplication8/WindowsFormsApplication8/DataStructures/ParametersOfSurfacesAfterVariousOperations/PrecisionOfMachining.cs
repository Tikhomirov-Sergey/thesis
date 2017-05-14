using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.ParametersOfSurfacesAfterVariousOperations
{
    public class PrecisionOfMachining
    {
        public string name { get; set; }
        public double kvalitet { get; set; }
        public double surfaceRoughnessRz { get; set; }
        public DataStructures.Interval recommendedIntervalRz { get; set; }
        public double thicknessOfDefectiveCoating { get; set; }
        public double coefficientOfRefinement { get; set; }
        public int idOperation { get; set; }
    }
}
