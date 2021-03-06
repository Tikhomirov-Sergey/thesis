﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class CalculationOfSurface
    {
        private ParametersOfSurface parametersOfPart;
        private DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation;

        private double[] accuracies;

        private double[] spatialDeviationP;
        private double[] deviationOfInstallationE;
        
        private double[] nominalAllowanceZnom;

        private double[] sizeOfWorkprieceAfterOperation;

        public CalculationOfSurface(ParametersOfSurface parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation)
        {
                this.parametersOfPart = parametersOfPart;
                this.parametersForCalculation = parametersForCalculation;
        }

        public ClassesToCalculate.ResultsOfCalculation[] calculation()
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

        private ClassesToCalculate.ResultsOfCalculation[] getResultsOfCalculation()
        {
            int numberOfOperations = this.parametersForCalculation.getNumberOfOperations();

            double tolerance = parametersOfPart.getAllowance();
            if(tolerance == 0)
            {
                tolerance = accuracies[numberOfOperations - 1];
            }
            else
            {
                accuracies[numberOfOperations - 1] = parametersOfPart.getAllowance();
            }

            this.rounding(tolerance);

            ClassesToCalculate.ResultsOfCalculation[] resultsOfCalculation = new ClassesToCalculate.ResultsOfCalculation[numberOfOperations];

            for(int i = 0;i < numberOfOperations; i++)
            {
                resultsOfCalculation[i] = new ClassesToCalculate.ResultsOfCalculation(accuracies[i], spatialDeviationP[i], deviationOfInstallationE[i], nominalAllowanceZnom[i], sizeOfWorkprieceAfterOperation[i]);
            }

            return resultsOfCalculation;
        }

        private void rounding(double tolerance)
        {

            for(int i = 0; i < this.parametersForCalculation.getNumberOfOperations(); i++)
            {
                try
                {
                    this.accuracies[i] = Rounding.rounding(this.accuracies[i], tolerance);
                    this.spatialDeviationP[i] = Rounding.rounding(this.spatialDeviationP[i], tolerance);
                    this.deviationOfInstallationE[i] = Rounding.rounding(this.deviationOfInstallationE[i], tolerance);
                    this.nominalAllowanceZnom[i] = Rounding.rounding(this.nominalAllowanceZnom[i], tolerance);
                    this.sizeOfWorkprieceAfterOperation[i] = Rounding.rounding(this.sizeOfWorkprieceAfterOperation[i], tolerance);
                }
                catch { MessageBox.Show("2"); }
            }
        }
    }
}
