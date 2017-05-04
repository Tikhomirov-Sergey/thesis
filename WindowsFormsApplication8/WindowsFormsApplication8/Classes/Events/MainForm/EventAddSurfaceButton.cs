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
                Surface.Name = "Surface" + Convert.ToString(form.SurfacesTreeView.Nodes.Count);
                Surface.Text = "Поверхность " + Convert.ToString(form.SurfacesTreeView.Nodes.Count);
                form.SurfacesTreeView.Nodes.Add(Surface);
            }
            catch { }
        }
    }
}
