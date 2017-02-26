using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersOperationFromTreeview
    {
        private string typeOfMachining = "";
        private string precisionOfMachining = "";
        private string surfaceRoughnessRz = "";
        private Interval recommendedIntervalRz = null;
        private string idOperation = "";
        private string kvalitet = "";
        private string thicknessOfDefectiveCoating = "";
        private string coefficientOfRefinement = "";

        public ParametersOperationFromTreeview(string typeOfMachining, string precisionOfMachining, string surfaceRoughnessRz,
            Interval recommendedIntervalRz, string idOperation, string kvalitet, string thicknessOfDefectiveCoating, string coefficientOfRefinement)
        {
            this.typeOfMachining = typeOfMachining;
            this.precisionOfMachining = precisionOfMachining;
            this.surfaceRoughnessRz = surfaceRoughnessRz;
            this.recommendedIntervalRz = recommendedIntervalRz;
            this.idOperation = idOperation;
            this.kvalitet = kvalitet;
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
            this.coefficientOfRefinement = coefficientOfRefinement;
        }

        public void setTypeOfMachining(string typeOfMachining)
        {
            this.typeOfMachining = typeOfMachining;
        }
        public string getTypeOfMachining()
        {
            return this.typeOfMachining;
        }

        public void setPrecisionOfMachining(string precisionOfMachining)
        {
            this.precisionOfMachining = precisionOfMachining;
        }
        public string getPrecisionOfMachining()
        {
            return this.precisionOfMachining;
        }

        public void setSurfaceRoughnessRz(string surfaceRoughnessRz)
        {
            this.surfaceRoughnessRz = surfaceRoughnessRz;
        }
        public string getSurfaceRoughnessRz()
        {
            return this.surfaceRoughnessRz;
        }
        
        public void setRecommendedIntervalRz(Interval interval)
        {
            this.recommendedIntervalRz = interval;
        }
        public Interval getRecommendedIntervalRz()
        {
            return this.recommendedIntervalRz;
        }

        public void setIdOperation(string idOperation)
        {
            this.idOperation = idOperation;
        }
        public string IdOperation()
        {
            return this.idOperation;
        }

        public void setKvalitet(string kvalitet)
        {
            this.kvalitet = kvalitet;
        }
        public string getKvalitet()
        {
            return this.kvalitet;
        }

        public void setThicknessOfDefectiveCoating(string thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
        }
        public string getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }

        public void setCoefficientOfRefinement(string coefficientOfRefinement)
        {
            this.coefficientOfRefinement = coefficientOfRefinement;
        }
        public string getCoefficientOfRefinement()
        {
            return this.coefficientOfRefinement;
        }
    }
}
