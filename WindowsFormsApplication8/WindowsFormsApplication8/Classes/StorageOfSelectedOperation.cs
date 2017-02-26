using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class StorageOfSelectedOperation
    {
        private static ParametersOperationFromTreeview parameters = null;

        public static void setParameters(ParametersOperationFromTreeview parametersOperation)
        {
            parameters = parametersOperation;
        }

        public static ParametersOperationFromTreeview getParameters()
        {
            return parameters;
        }

        public static void insertParametersOfOperationsInTextboxes(Form1 form)
        {
            form.TypeOfMachining.Text = parameters.getTypeOfMachining();
            form.PrecisionOfMachining.Text = parameters.getPrecisionOfMachining();
            form.SurfaceRoughnessRz.Text = parameters.getSurfaceRoughnessRz();
            form.ThicknessOfDefectiveCoating.Text = parameters.getThicknessOfDefectiveCoating();
            form.Kvalitet.Text = parameters.getKvalitet();
            form.CoefficientOfRefinement.Text = parameters.getCoefficientOfRefinement();

            string[] ListInstruments = Tables.getInaccuracyOfPositioningPart().getListInstruments();
            form.TypeOfInstrument.Items.AddRange(ListInstruments);
            form.TypeOfInstrument.SelectedIndex = 0;
        }
    }
}
