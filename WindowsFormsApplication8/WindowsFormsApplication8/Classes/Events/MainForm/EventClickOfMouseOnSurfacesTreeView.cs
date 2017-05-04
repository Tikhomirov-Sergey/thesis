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
            int selectedIndex = e.Node.Index;
            StorageOfSelectedOperation.setIndexSelectedSurface(selectedIndex);

            if (selectedIndex == 0)
            {
                EventClickOnButtonOfEditOfTechnologicalProcess.buttonEditProcess(form);
            }
            else
            {

            }
        }
    }
}
