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
            {if (e.Node.Level == 1)
                {
                    NameOfWorkpiece.Text = Convert.ToString(e.Node.Text);
                    Kvalitet.Text = Convert.ToString(e.Node.FirstNode.FirstNode.Text);
                    string[] S = new string[2];
                    
                    S = e.Node.FirstNode.NextNode.FirstNode.Text.Split(new Char[] { '_' });
                     surfaceRoughnessRz.Text = S[0];
                    S = S[1].Split(new Char[] { '-' });
                    Ra_max = Convert.ToDouble(S[1]);Ra_min = Convert.ToDouble(S[0]);
                   
                    ThicknessOfDefectiveCoating.Text = Convert.ToString(e.Node.FirstNode.NextNode.NextNode.FirstNode.Text);
                    l = Convert.ToString(e.Node.LastNode.FirstNode.Text);
                    if (Convert.ToInt32(e.Node.LastNode.FirstNode.Text) == 2 || Convert.ToInt32(e.Node.LastNode.FirstNode.Text) == 3) { ValidOffsetSurface.Enabled = true; label4.Enabled = true; label5.Enabled = true; } else { ValidOffsetSurface.Enabled = false; label4.Enabled = false; label5.Enabled = false; }
                
            }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            h = NameOfWorkpiece.Text + "|" + surfaceRoughnessRz.Text + "|" + ThicknessOfDefectiveCoating.Text + "|" + Kvalitet.Text+"|"+l+"|"+Convert.ToString(ValidOffsetSurface.Text);
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
            CheckCommas.checkCommas(surfaceRoughnessRz);
            try
            {
                if (surfaceRoughnessRz.Text == "") { surfaceRoughnessRz.Text = "0"; };
                surfaceRoughnessRa.Text = Convert.ToString((Convert.ToDouble(surfaceRoughnessRz.Text)) / 4 * 1000);
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(ThicknessOfDefectiveCoating);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(Kvalitet);
        }
        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(ValidOffsetSurface);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CheckCommas.checkCommas(surfaceRoughnessRa);
            // Для Rz 
            try
            {
                if (surfaceRoughnessRa.Text == "") { surfaceRoughnessRa.Text = "0"; };
                surfaceRoughnessRz.Text = Convert.ToString((Convert.ToDouble(surfaceRoughnessRa.Text)) * 4 / 1000);
            }
            catch { }
        }
    }

}
