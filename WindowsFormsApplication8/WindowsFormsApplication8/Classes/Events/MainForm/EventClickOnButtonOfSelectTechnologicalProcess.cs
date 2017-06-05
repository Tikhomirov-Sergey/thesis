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
            string nameSurface = "Поверхность 1";
            int countNodes = form.SurfacesTreeView.Nodes.Count;
            

            if (countNodes == 1)
            {
                form.SurfacesTreeView.Nodes.Add(nameSurface);

                Part.setNameSurfaceOnIndex(1, nameSurface);
                
            }

            StorageOfSelectedOperation.setIndexSelectedSurface(1);
            form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[1];

            form.NameSurface.Text = nameSurface;

            Part.copyTechnologicalProcessInSurface(1);
            Part.insertListOfOperationsInTreeView(form, 1);

            Part.insertListOfTechnologicalProcessInTreeView(form);

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
