using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStructures.CalculationOfSurface
{
    //Переход с индексом 0 - это заготовка
    class ParametersOperationsForCalculation
    {
        private double[] surfaceRoughnessRz;
        private double[] kvalitets;
        private double[] thicknessOfDefectiveCoating;
        private double[] coefficientOfRefinement;

        private int[] idOperation;
        private string[] typeOfInstrument;

        public ParametersOperationsForCalculation(double[] surfaceRoughnessRz, double[] kvalitets, 
            double[] thicknessOfDefectiveCoating, double[] coefficientOfRefinement, int[] idOperation, string[] typeOfInstrument)
        {
            this.surfaceRoughnessRz = surfaceRoughnessRz;
            this.kvalitets = kvalitets;
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
            this.coefficientOfRefinement = coefficientOfRefinement;
            this.idOperation = idOperation;
            this.typeOfInstrument = typeOfInstrument;
        }

        public double[] getSurfaceRoughnessRz()
        {
            return this.surfaceRoughnessRz;
        }

        public double[] getKvalitets()
        {
            return this.kvalitets;
        }

        public double[] getThicknessOfDefectiveCoating()
        {
            return this.thicknessOfDefectiveCoating;
        }

        public double[] getCoefficientOfRefinement()
        {
            return this.surfaceRoughnessRz;
        }

        public int[] getIdOperation()
        {
            return this.idOperation;
        }

        public string[] getTypeOfInstrument()
        {
            return this.typeOfInstrument;
        }

        public int getNumberOfOperations()
        {
            return this.idOperation.Length;
        }
    }
}
