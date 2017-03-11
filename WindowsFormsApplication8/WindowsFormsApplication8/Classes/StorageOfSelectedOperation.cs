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
            form.SurfaceRoughnessRz.Text = parameters.getSurfaceRoughnessRzToString();
            form.ThicknessOfDefectiveCoating.Text = parameters.getThicknessOfDefectiveCoatingToString();
            form.Kvalitet.Text = parameters.getKvalitetToString();
            form.CoefficientOfRefinement.Text = parameters.getCoefficientOfRefinementToString();

            form.TypeOfInstrument.Items.Clear();
            string[] ListInstruments = Tables.getInaccuracyOfPositioningPart().getListInstruments();
            form.TypeOfInstrument.Items.AddRange(ListInstruments);
            form.TypeOfInstrument.SelectedIndex = 0;
        }
    }
}
