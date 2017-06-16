using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.PaarametersOfWorkpieces
{
    public class Workpieces
    {
        public string nameOfWorkpiece { get; set; }
        public int kvalitet { get; set; }
        public double surfaceRoughnessRz { get; set; }
        public DataStructures.Interval recommendedIntervalRz { get; set; }
        public double thicknessOfDefectiveCoating { get; set; }
        public int idWorkpieces { get; set; }

        public string getNameOfWorkpieces()
        {
            return nameOfWorkpiece;
        }

        public ParametersWorkpiece getParametersWorkpiece(int indexWorkpriece)
        {
            WindowsFormsApplication8.Interval interval = new WindowsFormsApplication8.Interval(recommendedIntervalRz);

            ParametersWorkpiece workpiece = new ParametersWorkpiece(nameOfWorkpiece, idWorkpieces, indexWorkpriece, surfaceRoughnessRz, interval, kvalitet, thicknessOfDefectiveCoating);

            return workpiece;
        }
    }
}
