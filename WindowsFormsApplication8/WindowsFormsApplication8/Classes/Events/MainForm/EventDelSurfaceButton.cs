using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventDelSurfaceButton
    {
        public static void buttonDelSurface(EventArgs e, MainForm form)
        {
            
            int selectedIndex = StorageOfSelectedOperation.getIndexSelectedSurface();
            try
            {
                if (selectedIndex != 0)
                {
                    form.SurfacesTreeView.Nodes.RemoveAt(selectedIndex);

                    for (int i = 1; i < form.SurfacesTreeView.Nodes.Count; i++)
                    {

                        if (form.SurfacesTreeView.Nodes[i].Text == $"Поверхность {i + 1}")
                        {
                            string nameSurface = "Поверхность " + Convert.ToString(i);

                            form.SurfacesTreeView.Nodes[i].Text = nameSurface;
                            Part.getSurfaceOnIndex(i).setNameSurface(nameSurface);
                        }
                    }

                    Part.deleteSurface(selectedIndex);

                    StorageOfSelectedOperation.setIndexSelectedSurface(selectedIndex - 1);
                }
            
            }
            catch { }
        }
    }
}
