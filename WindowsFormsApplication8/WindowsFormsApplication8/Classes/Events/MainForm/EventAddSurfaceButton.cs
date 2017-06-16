using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventAddSurfaceButton
    {
        public static void buttonAddSurface(MainForm form)
        {
            try
            {
                TreeNode surface = new TreeNode();

                int count = form.SurfacesTreeView.Nodes.Count;

                Part.copyTechnologicalProcessInSurface(count);
                Part.insertListOfOperationsInTreeView(form, count);

                surface.Name = "notChange";
                surface.Text = "Поверхность " + Convert.ToString(count);

                
                form.SurfacesTreeView.Nodes.Add(surface);

                StorageOfSelectedOperation.setIndexSelectedSurface(count);
                form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[count];

                form.NameSurface.Text = surface.Text;
                Part.getSurfaceOnIndex(count).setNameSurface(surface.Text);

            }
            catch { }
        }
    }
}
