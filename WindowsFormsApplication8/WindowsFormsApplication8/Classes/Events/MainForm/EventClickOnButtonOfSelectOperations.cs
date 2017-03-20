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
                Part.addOperationInSurface(operation, 0);

                insertNameOperationInTextboxes(form, operation.getNameOperation());
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

        public static void insertNameOperationInTextboxes(MainForm form, string nameOperation)
        {
            form.treeView1.Nodes.Add(new TreeNode(nameOperation));
        }
    }
}
