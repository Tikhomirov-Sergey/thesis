using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventAddSurfaceButton
    {
        public static void buttonAddSurface(EventArgs e, MainForm form)
        {
            try
            {
                TreeNode Surface = new TreeNode();

                int count = form.SurfacesTreeView.Nodes.Count;

                Part.copyTechnologicalProcessInSurface(count);
                Part.insertListOfOperationsInTreeView(form, count);

                Surface.Name = "Surface" + Convert.ToString(count);
                Surface.Text = "Поверхность " + Convert.ToString(count);

                form.SurfacesTreeView.Nodes.Add(Surface);

                StorageOfSelectedOperation.setIndexSelectedSurface(count);
                form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[count];
            }
            catch { MessageBox.Show("buttonAddSurface"); }
        }
    }
}
