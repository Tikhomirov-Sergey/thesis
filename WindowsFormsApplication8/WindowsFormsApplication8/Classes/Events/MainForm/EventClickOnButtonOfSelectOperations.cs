using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSelectOperationsOrWorkpiece
    {
        public static void buttonOfSelectOperations(EventArgs e, MainForm form)
        {
            ParametersOperation operation = StorageOfSelectedOperation.getParameters();

            if(operation != null)
            {
                extractionOfParametersOfOperationFromTextBoxes(operation, form);
                Surfaces.addOperationInSurface(operation, 0);
                
                form.richTextBox1.Text = form.richTextBox1.Text + "\n" + operation.getNameOperation();
            }
        }

        private static ParametersOperation extractionOfParametersOfOperationFromTextBoxes(ParametersOperation operation, MainForm form)
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
    }

}
