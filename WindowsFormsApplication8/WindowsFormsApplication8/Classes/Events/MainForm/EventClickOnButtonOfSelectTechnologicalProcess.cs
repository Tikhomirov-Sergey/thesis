using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

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

            form.Surfaces.Visible = true;
            form.NameSurface.Visible = true;
            form.SurfacesTreeView.Visible = true;
            form.addSurfaceButton.Visible = true;
            form.delSurfaceButton.Visible = true;

            form.TreeOfOperations.Size = new Size(401,168);
            form.TreeOfOperations.Location = new Point(12,389);

            form.labelOperationsOrTechProcess.Size = new Size(91,13);
            form.labelOperationsOrTechProcess.Location = new Point(169, 373);

            form.SelectTechnologicalProcess.Visible = false;
            form.labelOperationsOrTechProcess.Text = "Тех. процесс";
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
