using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfEditOfTechnologicalProcess
    {
        public static void buttonEditProcess(MainForm form)
        {
            insertNameOperationsInTreeView(form);
        }

        public static void insertNameOperationsInTreeView(MainForm form)
        {
            Part.insertListOfOperationsInTreeView(form, 0);

            int countOperations = form.TreeOfSelectedOperations.Nodes.Count;
            form.TreeOfSelectedOperations.SelectedNode = form.TreeOfSelectedOperations.Nodes[countOperations - 1];
            form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[0];
            
        }
    }
}
