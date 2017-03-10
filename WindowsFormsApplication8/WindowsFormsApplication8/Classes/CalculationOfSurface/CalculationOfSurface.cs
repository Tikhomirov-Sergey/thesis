using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class CalculationOfSurface
    {
        private ParametersOfPart parametersOfPart;
        private DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation;

        private double[] accuracies;

        private double[] spatialDeviationP;
        private double[] deviationOfInstallationE;
        
        private double[] nominalAllowanceZnom;

        private double[] sizeOfWorkprieceAfterOperation;

        public CalculationOfSurface(ParametersOfPart parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation)
        {
                this.parametersOfPart = parametersOfPart;
                this.parametersForCalculation = parametersForCalculation;
        }

        public ClassesToCalculate.ResultsOfCalculation calculation()
        {
            if (this.checkOfIntervalsLenghtAndDiameter())
            {
                kvalitetToAccuracy();
                CalculationOfSpatialDeviation();
                CalculationOfDeviationOfInstallation();
                CalculationOfAllowance();
                CalculationOfSizeOfWorkprieceAfterOperation();

                return getResultsOfCalculation();
            }

            return null;
        }



        private bool checkOfIntervalsLenghtAndDiameter()
        {
            return this.checkOfIntervalLenght() && this.checkOfIntervalDiameter();
        }

        private bool checkOfIntervalLenght()
        {
            double lenghtOFPart = parametersOfPart.getLengthOfPart();
            Interval intervalOflenght = new Interval(0, 3150);
            bool checkOfLenght = intervalOflenght.checkOfInterval(lenghtOFPart);

            if (checkOfLenght)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Введена некорректная длинна", "Ошибка");
                return false;
            }
        }

        private bool checkOfIntervalDiameter()
        {
            double diameterOFPart = parametersOfPart.getDiameterOfPart();
            Interval intervalOfDiameter = new Interval(0, 3150);
            bool checkOfDiameter = intervalOfDiameter.checkOfInterval(diameterOFPart);

            if (checkOfDiameter)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Введен некорректный диаметр", "Ошибка");
                return false;
            }
        }
        
        private void kvalitetToAccuracy()
        {
            int numberOfOperations = this.parametersForCalculation.getNumberOfOperations();

            double[] kvalitets = this.parametersForCalculation.getKvalitets();
            double[] accuracies = new double[numberOfOperations];

            double diameterOfPart = parametersOfPart.getDiameterOfPart();

            for(int i = 0; i < numberOfOperations; i++)
            {
                TableOfTolerancesAndFits tableOfTolerancesAndFits = Tables.getTableOfTolerancesAndFits();
                double kvalitet = kvalitets[i];
                double accuracy = tableOfTolerancesAndFits.getAccuracy(kvalitet, diameterOfPart);
                accuracies[i] = accuracy;
            }
            this.accuracies = accuracies;
        }

        private void CalculationOfSpatialDeviation()
        {
            ClassesToCalculate.SpatialDeviation spatialDeviation = new ClassesToCalculate.SpatialDeviation(this.parametersOfPart, this.parametersForCalculation);
            this.spatialDeviationP = spatialDeviation.calculation();
        }

        private void CalculationOfDeviationOfInstallation()
        {
            ClassesToCalculate.DeviationOfInstallation deviationOfInstallation = new ClassesToCalculate.DeviationOfInstallation(this.parametersOfPart, this.parametersForCalculation);
            this.deviationOfInstallationE = deviationOfInstallation.calculation();
        }

        private void CalculationOfAllowance()
        {
            ClassesToCalculate.Allowance allowance = new ClassesToCalculate.Allowance(this.parametersOfPart, this.parametersForCalculation, this.spatialDeviationP, this.deviationOfInstallationE, this.accuracies);
            this.nominalAllowanceZnom = allowance.calculation();
        }

        private void CalculationOfSizeOfWorkprieceAfterOperation()
        {
            ClassesToCalculate.SizeOfWorkprieceAfterOperation sizeOfWorkprieceAfterOperation = new ClassesToCalculate.SizeOfWorkprieceAfterOperation(parametersOfPart, parametersForCalculation, nominalAllowanceZnom);
            this.sizeOfWorkprieceAfterOperation = sizeOfWorkprieceAfterOperation.calculation();
        }

        private ClassesToCalculate.ResultsOfCalculation getResultsOfCalculation()
        {
            ClassesToCalculate.ResultsOfCalculation resultsOfCalculation = new ClassesToCalculate.ResultsOfCalculation(this.accuracies, this.spatialDeviationP, this.deviationOfInstallationE, this.nominalAllowanceZnom, this.sizeOfWorkprieceAfterOperation);
            return resultsOfCalculation;
        }
    }
}
