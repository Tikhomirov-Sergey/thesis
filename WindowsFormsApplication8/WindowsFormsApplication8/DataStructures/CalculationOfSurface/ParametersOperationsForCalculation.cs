
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

        private double validOffsetSurfacePcm;

        public ParametersOperationsForCalculation(double[] surfaceRoughnessRz, double[] kvalitets, 
            double[] thicknessOfDefectiveCoating, double[] coefficientOfRefinement, int[] idOperation, string[] typeOfInstrument, double validOffsetSurfacePcm = 0)
        {
            this.surfaceRoughnessRz = surfaceRoughnessRz;
            this.kvalitets = kvalitets;
            this.thicknessOfDefectiveCoating = thicknessOfDefectiveCoating;
            this.coefficientOfRefinement = coefficientOfRefinement;
            this.idOperation = idOperation;
            this.typeOfInstrument = typeOfInstrument;
            this.validOffsetSurfacePcm = validOffsetSurfacePcm;
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
            return this.coefficientOfRefinement;
        }

        public int[] getIdOperation()
        {
            return this.idOperation;
        }

        public string[] getTypeOfInstrument()
        {
            return this.typeOfInstrument;
        }

        public double getValidOffsetSurfacePcm()
        {
            return this.validOffsetSurfacePcm;
        }

        public int getNumberOfOperations()
        {
            return this.idOperation.Length;
        }
    }
}
