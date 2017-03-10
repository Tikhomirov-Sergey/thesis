using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersOperation
    {
        private string typeOfMachining = "";
        private string precisionOfMachining = "";
        private string surfaceRoughnessRz = "";
        private Interval recommendedIntervalRz = null;
        private string idOperation = "";
        private string kvalitet = "";
        private string thicknessOfDefectiveCoating = "";
        private string coefficientOfRefinement = "";
        private string typeOfInstrument = "";

        public ParametersOperation(string typeOfMachining, string precisionOfMachining, string surfaceRoughnessRz,
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

        public string getNameOperation()
        {
            string nameOperation = this.typeOfMachining + "(" + this.precisionOfMachining + " , " + this.typeOfInstrument + ")";
            return nameOperation;
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
        public double getSurfaceRoughnessRzToDouble()
        {
            return Convert.ToDouble(this.surfaceRoughnessRz);
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
        public int getIdOperationToInt()
        {
            return Convert.ToInt32(this.idOperation);
        }

        public void setKvalitet(string kvalitet)
        {
            this.kvalitet = kvalitet;
        }
        public string getKvalitet()
        {
            return this.kvalitet;
        }
        public double getKvalitetToDouble()
        {
            return Convert.ToDouble(this.kvalitet);
        }

        public void setThicknessOfDefectiveCoating(string thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
        }
        public string getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }
        public double getThicknessOfDefectiveCoatingToDouble()
        {
            return Convert.ToDouble(this.thicknessOfDefectiveCoating);
        }

        public void setCoefficientOfRefinement(string coefficientOfRefinement)
        {
            this.coefficientOfRefinement = coefficientOfRefinement;
        }
        public string getCoefficientOfRefinement()
        {
            return this.coefficientOfRefinement;
        }
        public double getCoefficientOfRefinementToDouble()
        {
            return Convert.ToDouble(this.coefficientOfRefinement);
        }

        public void setTypeOfInstrument(string typeOfInstrument)
        {
            this.typeOfInstrument = typeOfInstrument;
        }
        public string getTypeOfInstrument()
        {
            return this.typeOfInstrument;
        }
    }
}
