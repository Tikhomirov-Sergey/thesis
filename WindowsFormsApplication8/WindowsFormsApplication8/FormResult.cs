using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace WindowsFormsApplication8
{
    public partial class FormResult : System.Windows.Forms.Form
    {

        public FormResult()
        {
            InitializeComponent();
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            ClickOnSurfacesTreeView.getSurfacesTreeView(this);

            ClickOnSurfacesTreeView.clickOnNode(1, this);
        }

        private void buttonSaveToDisk_Click(object sender, EventArgs e)
        {

             string text = ClickOnSaveToFile.getText();
             SaveFileDialog sfd = new SaveFileDialog();
             sfd.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

             if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 StreamWriter sw = new StreamWriter(sfd.FileName);
                 sw.WriteLine(richTextBox1.Text);
                 sw.Close();
             }
             
            
        }

        private void buttonSaveToBase_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
        }

        private void SurfacesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ClickOnSurfacesTreeView.clickOnNode(e, this);
        }
    }
}
