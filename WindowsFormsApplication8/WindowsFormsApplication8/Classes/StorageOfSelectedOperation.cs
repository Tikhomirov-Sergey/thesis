namespace WindowsFormsApplication8
{
    class StorageOfSelectedOperation
    {
        private static ParametersOperation parameters = null;

        public static void setParameters(ParametersOperation parametersOperation)
        {
            parameters = parametersOperation;
        }

        public static ParametersOperation getParameters()
        {
            return parameters;
        }

        public static void insertParametersOfOperationsInTextboxes(MainForm form)
        {
            form.TypeOfMachining.Text = parameters.getTypeOfMachining();
            form.PrecisionOfMachining.Text = parameters.getPrecisionOfMachining();
            form.SurfaceRoughnessRz.Text = parameters.getSurfaceRoughnessRz();
            form.ThicknessOfDefectiveCoating.Text = parameters.getThicknessOfDefectiveCoating();
            form.Kvalitet.Text = parameters.getKvalitet();
            form.CoefficientOfRefinement.Text = parameters.getCoefficientOfRefinement();

            form.TypeOfInstrument.Items.Clear();
            string[] ListInstruments = Tables.getInaccuracyOfPositioningPart().getListInstruments();
            form.TypeOfInstrument.Items.AddRange(ListInstruments);
            form.TypeOfInstrument.SelectedIndex = 0;
        }
    }
}
