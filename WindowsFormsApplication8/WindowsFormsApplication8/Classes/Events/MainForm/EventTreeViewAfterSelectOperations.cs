using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventTreeViewAfterSelectOperations
    {
        public static void alferSelect(MainForm form, TreeView sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in sender.Nodes)
            {
                node.BackColor = System.Drawing.Color.White;
                node.ForeColor = System.Drawing.Color.Black;
            }

            e.Node.ForeColor = System.Drawing.Color.White;
            e.Node.BackColor = System.Drawing.Color.FromArgb(0, 0, 160, 255);
        }
    }
}
