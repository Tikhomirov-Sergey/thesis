using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfDeleteOperation
    {
        public static void buttonDeleteOperation(MainForm form)
        {
            try
            {
                TreeView treeView = form.TreeOfSelectedOperations;
                int indexSelectedOperation = StorageOfSelectedOperation.getIndexSelectedOperation();

                if (indexSelectedOperation != 0)
                {
                    treeView.Nodes.RemoveAt(indexSelectedOperation);
                    Part.deleteOperation(0, indexSelectedOperation - 1);
                    StorageOfSelectedOperation.decrementOfIndex();
                    form.TreeOfSelectedOperations.SelectedNode = form.TreeOfSelectedOperations.Nodes[indexSelectedOperation - 1];
                }
            }
            catch { }
        }
    }
}
