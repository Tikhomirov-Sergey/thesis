using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public ParametersOperation(string typeOfMachining, string precisionOfMachining, double surfaceRoughnessRz,
            Interval recommendedIntervalRz, int idOperation, double kvalitet, double thicknessOfDefectiveCoating, double coefficientOfRefinement, string typeOfInstrument = "не выбрано")
        {
            this.typeOfMachining = typeOfMachining;
            this.precisionOfMachining = precisionOfMachining;
            this.surfaceRoughnessRz = surfaceRoughnessRz;
            this.recommendedIntervalRz = recommendedIntervalRz;
            this.idOperation = idOperation;
            this.kvalitet = kvalitet;
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
            this.coefficientOfRefinement = coefficientOfRefinement;
            this.typeOfInstrument = typeOfInstrument;
        }

        public ParametersOperation(string typeOfMachining, string precisionOfMachining, string surfaceRoughnessRz,
           Interval recommendedIntervalRz, string idOperation, string kvalitet, string thicknessOfDefectiveCoating, string coefficientOfRefinement, string typeOfInstrument = "не выбрано")
        {
            this.typeOfMachining = typeOfMachining;
            this.precisionOfMachining = precisionOfMachining;
            this.surfaceRoughnessRz = Convert.ToDouble(surfaceRoughnessRz);
            this.recommendedIntervalRz = recommendedIntervalRz;
            this.idOperation = Convert.ToInt32(idOperation);
            this.kvalitet = Convert.ToInt32(kvalitet);
            this.thicknessOfDefectiveCoating = Convert.ToDouble(thicknessOfDefectiveCoating);
            this.coefficientOfRefinement = Convert.ToDouble(coefficientOfRefinement);
            this.typeOfInstrument = typeOfInstrument;
        }

        public ParametersOperation(ParametersOperation operation)
        {
            this.typeOfMachining = operation.getTypeOfMachining();
            this.precisionOfMachining = operation.getPrecisionOfMachining();
            this.surfaceRoughnessRz = operation.getSurfaceRoughnessRz();
            this.recommendedIntervalRz = operation.getRecommendedIntervalRz();
            this.idOperation = operation.getIdOperation();
            this.kvalitet = operation.getKvalitet();
            this.thicknessOfDefectiveCoating = operation.getThicknessOfDefectiveCoating();
            this.coefficientOfRefinement = operation.getCoefficientOfRefinement();
            this.typeOfInstrument = operation.getTypeOfInstrument();

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
        
        public void setSurfaceRoughnessRz(double surfaceRoughnessRz)
        {
            this.surfaceRoughnessRz = surfaceRoughnessRz;
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

        public void setIdOperation(int idOperation)
        {
            this.idOperation = idOperation;
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

        public void setKvalitet(double kvalitet)
        {
            this.kvalitet = kvalitet;
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

        public void setThicknessOfDefectiveCoating(double thicknessOfDefectiveCoating)
        {
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
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

        public void setCoefficientOfRefinement(double coefficientOfRefinement)
        {
            this.coefficientOfRefinement = coefficientOfRefinement;
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
