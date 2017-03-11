using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class ParametersOperation
    {
        private string typeOfMachining;
        private string precisionOfMachining;
        private double surfaceRoughnessRz;
        private Interval recommendedIntervalRz;
        private int idOperation;
        private double kvalitet;
        private double thicknessOfDefectiveCoating;
        private double coefficientOfRefinement;
        private string typeOfInstrument;

        public ParametersOperation(string typeOfMachining, string precisionOfMachining, string surfaceRoughnessRz,
            Interval recommendedIntervalRz, string idOperation, string kvalitet, string thicknessOfDefectiveCoating, string coefficientOfRefinement)
        {
            this.typeOfMachining = typeOfMachining;
            this.precisionOfMachining = precisionOfMachining;
            this.surfaceRoughnessRz = Convert.ToDouble(surfaceRoughnessRz);
            this.recommendedIntervalRz = recommendedIntervalRz;
            this.idOperation = Convert.ToInt32(idOperation);
            this.kvalitet = Convert.ToDouble(kvalitet);
            this.thicknessOfDefectiveCoating = Convert.ToDouble(thicknessOfDefectiveCoating);
            this.coefficientOfRefinement = Convert.ToDouble(coefficientOfRefinement);
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
            this.surfaceRoughnessRz = Convert.ToDouble(surfaceRoughnessRz);
        }
        public double getSurfaceRoughnessRz()
        {
            return this.surfaceRoughnessRz;
        }
        public string getSurfaceRoughnessRzToString()
        {
            return Convert.ToString(this.surfaceRoughnessRz);
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
            this.idOperation = Convert.ToInt32(idOperation);
        }
        public int getIdOperation()
        {
            return this.idOperation;
        }
        public string getIdOperationToString()
        {
            return Convert.ToString(this.idOperation);
        }

        public void setKvalitet(string kvalitet)
        {
            this.kvalitet = Convert.ToDouble(kvalitet);
        }
        public double getKvalitet()
        {
            return this.kvalitet;
        }
        public string getKvalitetToString()
        {
            return Convert.ToString(this.kvalitet);
        }

        public void setThicknessOfDefectiveCoating(string thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = Convert.ToDouble(thicknessOfDefectiveCoating);
        }
        public double getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }
        public string getThicknessOfDefectiveCoatingToString()
        {
            return Convert.ToString(this.thicknessOfDefectiveCoating);
        }

        public void setCoefficientOfRefinement(string coefficientOfRefinement)
        {
            this.coefficientOfRefinement = Convert.ToDouble(coefficientOfRefinement);
        }
        public double getCoefficientOfRefinement()
        {
            return this.coefficientOfRefinement;
        }
        public string getCoefficientOfRefinementToString()
        {
            return Convert.ToString(this.coefficientOfRefinement);
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
