using System.Xml;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class XMLtoTreeView
    {
        public static void formationTreeView(string xmlFile, TreeView treeView)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlFile);

            treeView.Nodes.Clear();
            treeView.Nodes.Add(new TreeNode(xmlDocument.DocumentElement.Name));

            TreeNode rootNode = new TreeNode();
            rootNode = treeView.Nodes[0];

            AddNode(xmlDocument.DocumentElement, rootNode);

            treeView.CollapseAll();
            rootNode.Toggle();
        }

        protected static void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            } else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }
    }
}
