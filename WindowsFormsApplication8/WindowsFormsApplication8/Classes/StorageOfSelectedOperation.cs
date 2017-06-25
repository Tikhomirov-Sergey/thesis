using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class StorageOfSelectedOperation
    {
        private static Operation operation = null;
        private static int indexSelectOperation;
        private static int indexSelectSurface = 0;
        private static int lastIndexSelectSurface;

        public static void setOperation(Operation operation)
        {
            StorageOfSelectedOperation.operation = operation;
        }

        public static Operation getOperation()
        {
            return operation;
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
            lastIndexSelectSurface = indexSelectSurface;
            indexSelectSurface = indexSurface;
        }

        public static int getIndexSelectedSurface()
        {
            return indexSelectSurface;
        }

        public static int getLastIndexSelectedSurface()
        {
            return lastIndexSelectSurface;
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
            form.TypeOfMachining.Text = operation.getTypeOfMachining();
            selectTypeOfInstrument(form);

            /*
            form.TypeOfMachining.Text = operation.getTypeOfMachining();
            form.PrecisionOfMachining.Text = operation.getPrecisionOfMachining();
            form.SurfaceRoughnessRz.Text = operation.getSurfaceRoughnessRzToString();
            form.ThicknessOfDefectiveCoating.Text = operation.getThicknessOfDefectiveCoatingToString();
            form.Kvalitet.Text = operation.getKvalitetToString();
            form.CoefficientOfRefinement.Text = operation.getCoefficientOfRefinementToString();

            selectTypeOfInstrument(form);*/
        }

        private static void selectTypeOfInstrument(MainForm form)
        {
            form.TypeOfInstrument.Items.Clear();
            string[] ListInstruments = Tables.getInaccuracyOfPositioningPart().getListInstruments();
            form.TypeOfInstrument.Items.AddRange(ListInstruments);
            form.TypeOfInstrument.SelectedIndex = 0;

            try
            {
                string typeOfInstrument = operation.getTypeOfInstrument();
                int index = form.TypeOfInstrument.Items.IndexOf(typeOfInstrument);
                form.TypeOfInstrument.SelectedIndex = index;
            }
            catch { }
        }
    } 
}
