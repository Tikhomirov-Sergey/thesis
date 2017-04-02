using System;

namespace WindowsFormsApplication8.ClassesToCalculate
{
    class SpatialDeviation
    {
        private int numberOfOperations;

        private double lengthOfPart;
        private double diameterOfPart;

        private int[] idOperation;
        private double[] coefficientOfRefinement;

        private double validOffsetSurfacePcm;
        private double holeDepth;

        public SpatialDeviation(ParametersOfPart parametersOfPart, DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersForCalculation)
        {
            this.numberOfOperations = parametersForCalculation.getNumberOfOperations();

            this.lengthOfPart = parametersOfPart.getLengthOfPart();
            this.diameterOfPart = parametersOfPart.getDiameterOfPart();

            this.idOperation = parametersForCalculation.getIdOperation();
            this.coefficientOfRefinement = parametersForCalculation.getCoefficientOfRefinement();

            this.validOffsetSurfacePcm = parametersForCalculation.getValidOffsetSurfacePcm();
            this.holeDepth = parametersOfPart.getHoleDepth();
        }

        public double[] calculation()
        {
            double[] spatialDeviationP = new double[this.numberOfOperations];

            double deviationOfWorkpiece = calculationDeviationOfWorkpiece();
            spatialDeviationP[0] = deviationOfWorkpiece;

            for (int i = 1; i < this.numberOfOperations; i++)
            {
                spatialDeviationP[i] = deviationOfWorkpiece * this.coefficientOfRefinement[i];                
            }
            return spatialDeviationP;
        }

        private double calculationDeviationOfWorkpiece()
        {
            double deviationOfWorkpiece;

            if (isUsedDrilling())
            {
                deviationOfWorkpiece = deviationOfWorkpieceWhenDrilling();
            }
            else if(isUsedRolled())
            {
                deviationOfWorkpiece = deviationOfWorkpieceWhenRolled();
            }
            else
            {
                deviationOfWorkpiece = deviationOfWorkpieceWhenCastingOrStamping();
            }
            return deviationOfWorkpiece;
        }

        private bool isUsedDrilling()
        {
            int idDrilling = 8;
            
            bool isUsedDrilling = false;
            
            for(int i = 1; i < this.numberOfOperations; i++)
            {
                if(idDrilling == this.idOperation[i])
                {
                    isUsedDrilling = true;
                    break;
                }
            }

            return isUsedDrilling;
        }

        private bool isUsedRolled()
        {
            int[] idRolled = { 1, 6, 7 };
            int idWorkpiece = this.idOperation[0];

            bool isUsedRolled = false;

            foreach(int id in idRolled)
            {
                if(id == idWorkpiece)
                {
                    isUsedRolled = true;
                    break;
                }
            }
            return isUsedRolled;
        }

        private double deviationOfWorkpieceWhenRolled()
        {
            double specificCurvature = 0.005;

            double deviationOfWorkpiece;
            deviationOfWorkpiece = specificCurvature * this.lengthOfPart;
            return deviationOfWorkpiece;
        }

        private double deviationOfWorkpieceWhenCastingOrStamping()
        {
            double specificCurvature = Tables.getCurvatureOfImpressionDieForgings().getCoefficient(this.diameterOfPart);

            double validWarping = specificCurvature * this.lengthOfPart;
            double deviationOfWorkpiece;
            deviationOfWorkpiece = Math.Sqrt( Math.Pow(this.validOffsetSurfacePcm, 2) + Math.Pow(validWarping, 2));
            return deviationOfWorkpiece;
        }

        private double deviationOfWorkpieceWhenDrilling()
        {
            double specificShift = Tables.getShiftInAxisOfHoleDuringDrilling().getCoefficient(this.diameterOfPart);

            double deviationOfWorkpiece;
            deviationOfWorkpiece = specificShift * this.holeDepth;
            return deviationOfWorkpiece;
        }
    }
}
