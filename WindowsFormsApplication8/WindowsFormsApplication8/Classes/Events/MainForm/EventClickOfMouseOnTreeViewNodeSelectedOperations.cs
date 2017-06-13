using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOfMouseOnTreeViewNodeSelectedOperations
    {
        public static void clickOnNode(TreeNodeMouseClickEventArgs e, MainForm form)
        {
            int selectedIndex = e.Node.Index;
            StorageOfSelectedOperation.setIndexSelectedOperation(selectedIndex);

            if (selectedIndex == 0)
            {
                EventClickOnButtonOfSelectWorkpriece.buttonSelectWorkpriece(form);
            }
            else
            {
                int index = selectedIndex - 1;
                int idSelectedSurface = StorageOfSelectedOperation.getIndexSelectedSurface();
                
               Operation operation = Part.getSurfaceOnIndex(idSelectedSurface).getOperationOnIndex(index);
               StorageOfSelectedOperation.setOperation(operation);

                MessageBox.Show(operation.getIdOnTechnologicalProcess().ToString());
               StorageOfSelectedOperation.insertParametersOfOperationsInTextboxes(form);
            }
        }

    }
}
