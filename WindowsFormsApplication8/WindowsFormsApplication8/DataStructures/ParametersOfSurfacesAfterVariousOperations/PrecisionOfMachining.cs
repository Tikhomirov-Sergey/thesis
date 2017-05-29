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

        public bool checkInterval(double surfaceRoughness)
        {
            return recommendedIntervalRz.checkOfInterval(surfaceRoughness);
        }

        public ParametersOperation getParametersOperation(string typeOfMachining)
        {
            WindowsFormsApplication8.Interval interval = new WindowsFormsApplication8.Interval(recommendedIntervalRz);

            ParametersOperation parameters = new ParametersOperation(typeOfMachining, name, surfaceRoughnessRz, interval, idOperation, kvalitet, thicknessOfDefectiveCoating, coefficientOfRefinement);

            return parameters;
        }
    }
}
