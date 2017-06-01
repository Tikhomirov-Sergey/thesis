using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSelectTechnologicalProcess
    {
        public static void buttonSelectProcess(MainForm form)
        {
            int countNodes = form.SurfacesTreeView.Nodes.Count;

            if (countNodes == 1)
            {
                form.SurfacesTreeView.Nodes.Add("Поверхность 1");
            }

            StorageOfSelectedOperation.setIndexSelectedSurface(1);
            form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[1];

            form.TreeOfSelectedOperations.Nodes.Clear();



            enabledTextBoxes(form);
        }

        private static void enabledTextBoxes(MainForm form)
        {
            form.addSurfaceButton.Enabled = true;
            form.delSurfaceButton.Enabled = true;
            form.SurfacesTreeView.Enabled = true;
            form.CalculationOfSchema.Visible = true;
        }
        
    }
}
