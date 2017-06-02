using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.ClassesToCalculate
{
    public class ResultsOfCalculation
    {
        private double accuracies;

        private double spatialDeviationP;
        private double deviationOfInstallationE;

        private double nominalAllowanceZnom;

        private double sizeOfWorkprieceAfterOperation;
        
        public ResultsOfCalculation(double accuracies, double spatialDeviationP, double deviationOfInstallationE,
            double nominalAllowanceZnom, double sizeOfWorkprieceAfterOperation)
        {
            this.accuracies = accuracies;

            this.spatialDeviationP = spatialDeviationP;
            this.deviationOfInstallationE = deviationOfInstallationE;

            this.nominalAllowanceZnom = nominalAllowanceZnom;

            this.sizeOfWorkprieceAfterOperation = sizeOfWorkprieceAfterOperation;
        }

        public double getAccuracies()
        {
            return this.accuracies;
        }

        public double getSpatialDeviation()
        {
            return this.spatialDeviationP;
        }

        public double getdeviationOfInstallation()
        {
            return this.deviationOfInstallationE;
        }

        public double getNominalAllowance()
        {
            return this.nominalAllowanceZnom;
        }

        public double getSizeOfWorkprieceAfterOperation()
        {
            return this.sizeOfWorkprieceAfterOperation;
        }

    }
}
