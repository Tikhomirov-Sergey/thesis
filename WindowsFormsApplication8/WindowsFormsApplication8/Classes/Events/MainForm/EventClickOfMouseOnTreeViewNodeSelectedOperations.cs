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
                int index = e.Node.Index - 1;
                ParametersOperation parametersOperation = Part.getSurfaceOnIndex(0).getOperationOnIndex(index);
                StorageOfSelectedOperation.setParameters(parametersOperation);
                StorageOfSelectedOperation.insertParametersOfOperationsInTextboxes(form);
            }
        }

    }
}
