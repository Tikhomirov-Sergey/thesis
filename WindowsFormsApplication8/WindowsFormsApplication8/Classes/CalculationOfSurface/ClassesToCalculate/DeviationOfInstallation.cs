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


        public DeviationOfInstallation(ParametersOfPart parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation)
        {
            this.numberOfOperations = parametersForCalculation.getNumberOfOperations();
            this.lengthOfPart = parametersOfPart.getLengthOfPart();
            this.diameterOfPart = parametersOfPart.getDiameterOfPart();

            this.typeOfInstrument = parametersForCalculation.getTypeOfInstrument();
            this.idOperation = parametersForCalculation.getIdOperation();
        }

        /*public double[] calculation()
        {
            double requiredSize;

            for (int i = 1; i < numberOfOperations; i++)
            {
                requiredSize = chooseOfRequiredSize(this.typeOfInstrument[i]);

            }
        }*/

        private double chooseOfRequiredSize(string typeOfInstrument)
        {
            string[] instrumentWhenDiameter = { "с винтовыми или эксцентриковыми зажимами", "с пневматическим зажимом" };

            bool requiredSizeIsDiameter = false;

            foreach(string instrument in instrumentWhenDiameter)
            {
                if (instrument.Equals(typeOfInstrument))
                {
                    requiredSizeIsDiameter = true;
                }
            }

            double requiredSize;

            if (requiredSizeIsDiameter)
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
