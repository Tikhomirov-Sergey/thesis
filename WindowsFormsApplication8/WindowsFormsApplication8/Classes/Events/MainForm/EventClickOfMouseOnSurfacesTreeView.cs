using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOfMouseOnSurfacesTreeView
    {
        public static void clickOnNode(TreeNodeMouseClickEventArgs e, MainForm form)
        {
            int selectedIndexSurface = e.Node.Index;
            StorageOfSelectedOperation.setIndexSelectedSurface(selectedIndexSurface);

        }
    }
}
