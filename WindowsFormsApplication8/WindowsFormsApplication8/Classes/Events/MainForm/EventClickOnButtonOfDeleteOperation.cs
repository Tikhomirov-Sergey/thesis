﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfDeleteOperation
    {
        public static void buttonDeleteOperation(MainForm form)
        {
            TreeView treeView = form.treeView1;
            int countNodesOfTreeView = treeView.Nodes.Count;

            if (countNodesOfTreeView > 1)
            {
                treeView.Nodes.RemoveAt(countNodesOfTreeView - 1);
                Part.deleteOperation(0, countNodesOfTreeView - 2);
            }
        }
    }
}
