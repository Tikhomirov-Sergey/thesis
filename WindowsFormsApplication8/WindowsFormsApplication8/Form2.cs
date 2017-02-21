using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        XmlDocument xmlDoc;string h;double Ra_min, Ra_max;
        string xmlpath = @"table1.xml"; string l;
        public Form2()
        {
            InitializeComponent();
        }
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
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
            }

            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlpath);

            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xmlDoc.DocumentElement.Name));

            TreeNode rootNode = new TreeNode();
            rootNode = treeView1.Nodes[0];

            AddNode(xmlDoc.DocumentElement, rootNode);

            treeView1.CollapseAll();
            rootNode.Toggle();
            
            textBox5.Enabled = false; label4.Enabled = false; label5.Enabled = false; textBox5.Text = "0";
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {if (e.Node.Level == 1)
                {
                    textBox3.Text = Convert.ToString(e.Node.Text);
                    textBox4.Text = Convert.ToString(e.Node.FirstNode.FirstNode.Text);
                    string[] S = new string[2];
                    
                    S = e.Node.FirstNode.NextNode.FirstNode.Text.Split(new Char[] { '_' });
                     textBox1.Text = S[0];
                    S = S[1].Split(new Char[] { '-' });
                    Ra_max = Convert.ToDouble(S[1]);Ra_min = Convert.ToDouble(S[0]);
                   
                    textBox2.Text = Convert.ToString(e.Node.FirstNode.NextNode.NextNode.FirstNode.Text);
                    l = Convert.ToString(e.Node.LastNode.FirstNode.Text);
                    if (Convert.ToInt32(e.Node.LastNode.FirstNode.Text) == 2 || Convert.ToInt32(e.Node.LastNode.FirstNode.Text) == 3) { textBox5.Enabled = true; label4.Enabled = true; label5.Enabled = true; } else { textBox5.Enabled = false; label4.Enabled = false; label5.Enabled = false; }
                
            }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            h = textBox3.Text + "|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox4.Text+"|"+l+"|"+Convert.ToString(textBox5.Text);
            Close();
        }
        public string Data
        {
            get
            {
                return Convert.ToString(h);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox1);
            try
            {
                if (textBox1.Text == "") { textBox1.Text = "0"; };
                textBox6.Text = Convert.ToString((Convert.ToDouble(textBox1.Text)) / 4 * 1000);
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox4);
        }
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(textBox6);
            // Для Rz 
            try
            {
                if (textBox6.Text == "") { textBox6.Text = "0"; };
                textBox1.Text = Convert.ToString((Convert.ToDouble(textBox6.Text)) * 4 / 1000);
            }
            catch { }
        }
    }

}
