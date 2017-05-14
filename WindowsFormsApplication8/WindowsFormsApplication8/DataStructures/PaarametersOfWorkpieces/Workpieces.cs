using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.PaarametersOfWorkpieces
{
    public class Workpieces
    {
        public string nameOfWorkpiece { get; set; }
        public double kvalitet { get; set; }
        public double surfaceRoughnessRz { get; set; }
        public DataStructures.Interval recommendedIntervalRz { get; set; }
        public double thicknessOfDefectiveCoating { get; set; }
        public int idWorkpieces { get; set; }
    }
}
