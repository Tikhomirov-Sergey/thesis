using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSelectOperationsOrWorkpiece
    {
        public static void buttonOfSelectOperations(EventArgs e, MainForm form)
        {
            ParametersOperation operation = StorageOfSelectedOperation.getParameters();

            if (operation != null)
            {
                extractionOfParametersOfOperationFromTextBoxes(operation, form);

                int indexSelectedOperation = StorageOfSelectedOperation.getIndexSelectedOperation();
                Part.addOperationInSurface(operation, 0, indexSelectedOperation);

                insertNameOperationInTextboxes(form, operation.getNameOperation(), indexSelectedOperation);

                operation = new ParametersOperation(operation);
                StorageOfSelectedOperation.setParameters(operation);
            }
        }

        public static ParametersOperation extractionOfParametersOfOperationFromTextBoxes(ParametersOperation operation, MainForm form)
        {
            string typeOfMachining = form.TypeOfMachining.Text;
            string precisionOfMachining = form.PrecisionOfMachining.Text;
            string surfaceRoughnessRz = form.SurfaceRoughnessRz.Text;
            string typeOfInsrument = form.TypeOfInstrument.Text;

            operation.setTypeOfMachining(typeOfMachining);
            operation.setPrecisionOfMachining(precisionOfMachining);
            operation.setSurfaceRoughnessRz(surfaceRoughnessRz);
            operation.setTypeOfInstrument(typeOfInsrument);

            return operation;
        }

        public static void insertNameOperationInTextboxes(MainForm form, string nameOperation,int indexSelectedOperation)
        {
            form.TreeOfSelectedOperations.Nodes.Insert(indexSelectedOperation + 1, nameOperation);
            form.TreeOfSelectedOperations.SelectedNode = form.TreeOfSelectedOperations.Nodes[indexSelectedOperation + 1];
            StorageOfSelectedOperation.incrementOfIndex();
        }
    }
}
