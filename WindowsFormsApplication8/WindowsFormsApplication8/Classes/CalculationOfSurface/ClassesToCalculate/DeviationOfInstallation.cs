using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.ClassesToCalculate
{
    class DeviationOfInstallation
    {
        private int numberOfOperations;

        private double lengthOfPart;
        private double diameterOfPart;

        private string[] typeOfInstrument;
        private int[] idOperation;

        private InaccuracyOfPositioningPart table;


        public DeviationOfInstallation(ParametersOfPart parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation)
        {
            this.numberOfOperations = parametersForCalculation.getNumberOfOperations();
            this.lengthOfPart = parametersOfPart.getLengthOfPart();
            this.diameterOfPart = parametersOfPart.getDiameterOfPart();

            this.typeOfInstrument = parametersForCalculation.getTypeOfInstrument();
            this.idOperation = parametersForCalculation.getIdOperation();
            this.table = Tables.getInaccuracyOfPositioningPart();
        }

        public double[] calculation()
        {
            double requiredSize;
            double[] deviationOfInstallation = new double[numberOfOperations];
            deviationOfInstallation[0] = 0;

            for (int i = 1; i < numberOfOperations; i++)
            {
                requiredSize = chooseOfRequiredSize(this.typeOfInstrument[i]);

                if (typeOfInstrument[i].Equals(typeOfInstrument[i - 1]))
                {
                    deviationOfInstallation[i] = 0;
                }
                else
                {
                    deviationOfInstallation[i] = table.getDeviationOfInstallation(requiredSize, this.idOperation[i], typeOfInstrument[i]);
                }

            }

            return deviationOfInstallation;
        }

        private double chooseOfRequiredSize(string typeOfInstrument)
        {
            double requiredSize;
            bool usedSizeIsDiameter = this.table.usedSizeIsDiameter(typeOfInstrument);

            if (usedSizeIsDiameter)
            {
                requiredSize = this.diameterOfPart;
            }
            else
            {
                requiredSize = this.lengthOfPart;
            }

            return requiredSize;
        }
    }
}
