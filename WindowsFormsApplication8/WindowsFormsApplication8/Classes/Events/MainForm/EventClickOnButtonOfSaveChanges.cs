using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSaveChanges
    {
        public static void buttonOfSaveChanges(EventArgs e, MainForm form)
        {
            try
            {
                int selectedOperation = StorageOfSelectedOperation.getIndexSelectedOperation();
                if (selectedOperation != 0)
                {
                    ParametersOperation operation = Part.getSurfaceOnIndex(0).getOperationOnIndex(selectedOperation - 1);

                    extractionOfParametersOfOperationFromTextBoxes(operation, form);
                    insertNameOperationInTreeView(form, selectedOperation);
                }
            }
            catch { }
        }

        public static void extractionOfParametersOfOperationFromTextBoxes(ParametersOperation operation, MainForm form)
        {
            string typeOfMachining = form.TypeOfMachining.Text;
            string precisionOfMachining = form.PrecisionOfMachining.Text;
            string surfaceRoughnessRz = form.SurfaceRoughnessRz.Text;
            string typeOfInsrument = form.TypeOfInstrument.Text;

            operation.setTypeOfMachining(typeOfMachining);
            operation.setPrecisionOfMachining(precisionOfMachining);
            operation.setSurfaceRoughnessRz(surfaceRoughnessRz);
            operation.setTypeOfInstrument(typeOfInsrument);
        }

        private static void insertNameOperationInTreeView(MainForm form, int selectedOperation)
        {
            Part.insertListOfOperationsInTreeView(form);
        }
    }
}
