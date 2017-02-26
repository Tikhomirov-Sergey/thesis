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
        string h; double Ra_min, Ra_max; string l;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string xmlpath = @"XMLFiles/ParametersOfWorkpieces.xml";
            XMLtoTreeView.formationTreeView(xmlpath, TreeOfWorkpiece);

            ValidOffsetSurface.Enabled = false; label4.Enabled = false; label5.Enabled = false; ValidOffsetSurface.Text = "0";
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                EventClickOfMouseOnTreeViewNode.clickOnTreeWorkpiece(e, this);
            }
            catch { MessageBox.Show("Повреждены XML таблицы", "Ошибка"); }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            h = NameOfWorkpiece.Text + "|" + SurfaceRoughnessRz.Text + "|" + ThicknessOfDefectiveCoating.Text + "|" + Kvalitet.Text+"|"+l+"|"+Convert.ToString(ValidOffsetSurface.Text);
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
            try
            {
                SurfaceRoughnessRa.Text = ConversionRoughnessRzAndRa.stringRzToRa(SurfaceRoughnessRz.Text);
            }
            catch {SurfaceRoughnessRa.Text = ""; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SurfaceRoughnessRz.Text = ConversionRoughnessRzAndRa.stringRaToRz(SurfaceRoughnessRa.Text);
            }
            catch {SurfaceRoughnessRz.Text = ""; }
        }

        private void TreeOfWorkpiece_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void KeyPressForTextBoxWithDouble(object sender, KeyPressEventArgs e)
        {
            EventKeyPressForTextBox.keyPressForTextBoxWithDouble(sender, e);
        }
    }

}
