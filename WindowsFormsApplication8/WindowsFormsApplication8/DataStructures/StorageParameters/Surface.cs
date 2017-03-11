using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Surface
    {
        private string nameSurface = "";
        private ParametersOperation[] operations = new ParametersOperation[0];

        private ClassesToCalculate.ResultsOfCalculation resultsOfCalculation = null;

        public void setNameSurface(string nameSurface)
        {
            this.nameSurface = nameSurface;
        }

        public string getNameSurface()
        {
            return this.nameSurface;
        }
        
        public void setOpetation(ParametersOperation operation)
        {
            int length = this.operations.Length;
            Array.Resize(ref this.operations, length+1);
            this.operations[length] = operation;
        }
        
        public ParametersOperation[] getOperations()
        {
            return this.operations;
        }

        public ParametersOperation getOperationOnIndex(int indexOperation)
        {
            try
            {
                return operations[indexOperation];
            }
            catch { return null; }
        }

        public string[] getListOperations()
        {
            int length = this.operations.Length;
            string[] list = new string[length];

            for(int i = 0; i < length; i++)
            {
                list[i] = this.operations[i].getNameOperation();
            }

            return list;
        }

        public int getNumberOfOperations()
        {
            return this.operations.Length;
        }

        public void calculationOFSurface()
        {
            ParametersOfPart parametersOfPart = Part.getParametersOfPart();
            DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parametersOperations = this.getParametersOperationsForCalculation();

            CalculationOfSurface calculationOfSurface = new CalculationOfSurface(parametersOfPart, parametersOperations);
            this.resultsOfCalculation = calculationOfSurface.calculation();
        }

        private DataStructures.CalculationOfSurface.ParametersOperationsForCalculation getParametersOperationsForCalculation()
        {
            double[] surfaceRoughnessRz = new double[this.getNumberOfOperations() + 1]; ;
            double[] kvalitets = new double[this.getNumberOfOperations() + 1]; ;
            double[] thicknessOfDefectiveCoating = new double[this.getNumberOfOperations() + 1]; ;
            double[] coefficientOfRefinement = new double[this.getNumberOfOperations() + 1]; ;

            int[] idOperation = new int[this.getNumberOfOperations() + 1]; ;
            string[] typeOfInstrument = new string[this.getNumberOfOperations() + 1];

            ParametersWorkpiece workpiece = Part.getWorkpiece();

            surfaceRoughnessRz[0] = workpiece.getSurfaceRoughnessRzToDouble();
            kvalitets[0] = workpiece.getKvalitetToDouble();
            thicknessOfDefectiveCoating[0] = workpiece.getThicknessOfDefectiveCoatingToDouble();

            idOperation[0] = workpiece.getIdWorkpieceToInt();

            double validOffsetSurface = workpiece.getValidOffsetSurfaceToDouble();

            for (int i = 0; i < this.getNumberOfOperations(); i++)
            {
                ParametersOperation operation = this.operations[i];

                surfaceRoughnessRz[i + 1] = operation.getSurfaceRoughnessRz();
                kvalitets[i + 1] = operation.getKvalitet();
                thicknessOfDefectiveCoating[i + 1] = operation.getThicknessOfDefectiveCoating();
                coefficientOfRefinement[i + 1] = operation.getCoefficientOfRefinement();

                idOperation[i + 1] = operation.getIdOperation();
                typeOfInstrument[i + 1] = operation.getTypeOfInstrument();
            }

            DataStructures.CalculationOfSurface.ParametersOperationsForCalculation parameters = new DataStructures.CalculationOfSurface.ParametersOperationsForCalculation(surfaceRoughnessRz, kvalitets, thicknessOfDefectiveCoating, coefficientOfRefinement, idOperation, typeOfInstrument, validOffsetSurface);
            return parameters;
        }

        public ClassesToCalculate.ResultsOfCalculation getResultsOfCalculation()
        {
            return this.resultsOfCalculation;
        }
    }
}
