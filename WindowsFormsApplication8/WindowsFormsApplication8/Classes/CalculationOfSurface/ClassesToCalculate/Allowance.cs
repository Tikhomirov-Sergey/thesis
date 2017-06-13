using System;

namespace WindowsFormsApplication8.ClassesToCalculate
{
    class Allowance
    {
        private int numberOfOperations;

        private double[] surfaceRoughnessRz;
        private double[] thicknessOfDefectiveCoating;

        private double[] spatialDeviationP;
        private double[] deviationOfInstallationE;

        private double[] accuracies;

        private int typeOfProcessedSurface;
        private int typeOfAllowance;
        

        private double[] minimumAllowanceZmin;

        public Allowance(ParametersOfSurface parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation,
            double[] spatialDeviationP, double[] deviationOfInstallationE, double[] accuracies)
        {
            this.numberOfOperations = parametersForCalculation.getNumberOfOperations();

            this.surfaceRoughnessRz = parametersForCalculation.getSurfaceRoughnessRz();
            this.thicknessOfDefectiveCoating = parametersForCalculation.getThicknessOfDefectiveCoating();

            this.spatialDeviationP = spatialDeviationP;
            this.deviationOfInstallationE = deviationOfInstallationE;

            this.accuracies = accuracies;

            this.typeOfProcessedSurface = parametersOfPart.getTypeOfProcessedSurface().getIndex();
            this.typeOfAllowance = parametersOfPart.getTypeOfAllowance().getIndex();
        }

        public double[] calculation()
        {
            this.minimumAllowanceZmin = calculationMinimumAllowance();

            return calculationNominalAllowance();
        }
        
        private double[] calculationMinimumAllowance()
        {
            double[] minimumAllowanceZmin;

            if(this.typeOfProcessedSurface == 1)
            {
                minimumAllowanceZmin = calculationMinimumAllowanceForFlatSurfaces();
            }
            else
            {
                minimumAllowanceZmin = calculationMinimumAllowanceForSurfacesOfRotation();
            }

            return minimumAllowanceZmin;
        }

        private double[] calculationMinimumAllowanceForFlatSurfaces()
        {
            double[] minimumAllowanceZmin = new double[this.numberOfOperations];

            for (int i = 1; i < this.numberOfOperations; i++)
            {
                minimumAllowanceZmin[i] = this.surfaceRoughnessRz[i - 1] + this.thicknessOfDefectiveCoating[i - 1] + this.spatialDeviationP[i - 1] + this.deviationOfInstallationE[i];
            }

            return minimumAllowanceZmin;
        }

        private double[] calculationMinimumAllowanceForSurfacesOfRotation()
        {
            double[] minimumAllowanceZmin = new double[this.numberOfOperations];

            for (int i = 1; i < this.numberOfOperations; i++)
            {
                minimumAllowanceZmin[i] = this.surfaceRoughnessRz[i - 1] + this.thicknessOfDefectiveCoating[i - 1] + Math.Sqrt( Math.Pow(this.spatialDeviationP[i - 1], 2) + Math.Pow(this.deviationOfInstallationE[i], 2));
            }

            return minimumAllowanceZmin;
        }

       private double[] calculationNominalAllowance()
        {
            double[] nominalAllowanceZnom;

            if(this.typeOfAllowance == 1)
            {
                nominalAllowanceZnom = calculationNominalUnilateralAllowance();
            }
            else
            {
                nominalAllowanceZnom = calculationNominalBilateralAllowance();
            }

            return nominalAllowanceZnom;
        }

        private double[] calculationNominalUnilateralAllowance()
        {
            double[] nominalAllowanceZnom = new double[this.numberOfOperations];

            for (int i = 1; i < this.numberOfOperations; i++)
            {
                nominalAllowanceZnom[i] = this.minimumAllowanceZmin[i] + this.accuracies[i - 1];
            }

            return nominalAllowanceZnom;
        }

        private double[] calculationNominalBilateralAllowance()
        {
            double[] nominalAllowanceZnom = new double[this.numberOfOperations];

            for(int i = 1; i < this.numberOfOperations; i++)
            {
                nominalAllowanceZnom[i] = 2 * this.minimumAllowanceZmin[i] + this.accuracies[i - 1];
            }

            return nominalAllowanceZnom;
        }
    }
}
