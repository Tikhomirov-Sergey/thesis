using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.ClassesToCalculate
{
    class SizeOfWorkprieceAfterOperation
    {
        private int numberOfOperations;

        private double diameterOfPart;
        private int typeOfPart;

        private double[] nominalAllowanceZnom;

        public SizeOfWorkprieceAfterOperation(ParametersOfPart parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation, double[] nominalAllowanceZnom)
        {
            this.numberOfOperations = parametersForCalculation.getNumberOfOperations();

            this.diameterOfPart = parametersOfPart.getDiameterOfPart();
            this.typeOfPart = parametersOfPart.getTypeOfPart();

            this.nominalAllowanceZnom = nominalAllowanceZnom;
        }

        public double[] calculation()
        {
            double[] sizeOfWorkprieceAfterOperation;

            if (this.typeOfPart == 1)
            {
                sizeOfWorkprieceAfterOperation = calculationForHole();
            }
            else
            {
                sizeOfWorkprieceAfterOperation = calculationForShaft();
            }

            return sizeOfWorkprieceAfterOperation;
        }
        
        private double[] calculationForHole()
        {
            double[] sizeOfWorkprieceAfterOperation = new double[this.numberOfOperations];

            for (int i = numberOfOperations - 2; i >= 0; i--)
            {
                sizeOfWorkprieceAfterOperation[i] = sizeOfWorkprieceAfterOperation[i + 1] - this.nominalAllowanceZnom[i + 1];
            }

            return sizeOfWorkprieceAfterOperation;
        }

        private double[] calculationForShaft()
        {
            double[] sizeOfWorkprieceAfterOperation = new double[this.numberOfOperations];

            sizeOfWorkprieceAfterOperation[this.numberOfOperations - 1] = this.diameterOfPart;

            for (int i = numberOfOperations - 2; i >= 0; i--)
            {
                sizeOfWorkprieceAfterOperation[i] = sizeOfWorkprieceAfterOperation[i + 1] + this.nominalAllowanceZnom[i + 1];
            }

            return sizeOfWorkprieceAfterOperation;
        }
    }
}
