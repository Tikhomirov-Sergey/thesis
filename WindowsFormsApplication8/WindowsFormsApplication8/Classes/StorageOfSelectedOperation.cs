using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class StorageOfSelectedOperation
    {
        private static ParametersOperation parameters = null;
        private static int indexSelectOperation;
        private static int indexSelectSurface;

        public static void setParameters(ParametersOperation parametersOperation)
        {
            parameters = parametersOperation;
        }

        public static ParametersOperation getParameters()
        {
            return parameters;
        }

        public static void setIndexSelectedOperation(int index)
        {
            indexSelectOperation = index;
        }

        public static int getIndexSelectedOperation()
        {
            return indexSelectOperation;
        }

        public static void setIndexSelectedSurface(int indexSurface)
        {
            indexSelectSurface = indexSurface;
        }

        public static int getIndexSelectedSurface()
        {
            return indexSelectSurface;
        }

        public static void incrementOfIndex()
        {
            indexSelectOperation++;
        }

        public static void decrementOfIndex()
        {
            indexSelectOperation--;
        }

        public static void insertParametersOfOperationsInTextboxes(MainForm form)
        {
            form.TypeOfMachining.Text = parameters.getTypeOfMachining();
            form.PrecisionOfMachining.Text = parameters.getPrecisionOfMachining();
            form.SurfaceRoughnessRz.Text = parameters.getSurfaceRoughnessRzToString();
            form.ThicknessOfDefectiveCoating.Text = parameters.getThicknessOfDefectiveCoatingToString();
            form.Kvalitet.Text = parameters.getKvalitetToString();
            form.CoefficientOfRefinement.Text = parameters.getCoefficientOfRefinementToString();

            selectTypeOfInstrument(form);
        }

        private static void selectTypeOfInstrument(MainForm form)
        {
            form.TypeOfInstrument.Items.Clear();
            string[] ListInstruments = Tables.getInaccuracyOfPositioningPart().getListInstruments();
            form.TypeOfInstrument.Items.AddRange(ListInstruments);
            form.TypeOfInstrument.SelectedIndex = 0;

            try
            {
                string typeOfInstrument = parameters.getTypeOfInstrument();
                int index = form.TypeOfInstrument.Items.IndexOf(typeOfInstrument);
                form.TypeOfInstrument.SelectedIndex = index;
            }
            catch { }
        }
    } 
}
