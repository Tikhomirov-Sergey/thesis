using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using Microsoft.Data.ConnectionUI;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Server;

namespace WindowsFormsApplication8
{
    
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            TypeOfPart.Items.AddRange(new string[] { "вал", "отверстие" });
            TypeOfProcessedSurface.Items.AddRange(new string[] { "цилиндрическая", "плоская" });
            TypeOfAllowance.Items.AddRange(new string[] { "двухсторонний", "односторонний" });

            string nameSurface = "Главный технологический процесс";
            SurfacesTreeView.Nodes.Add(nameSurface);
            NameSurface.Text = nameSurface;

            TypeOfPart.SelectedIndex = 0;
            TypeOfProcessedSurface.SelectedIndex = 0;
            TypeOfAllowance.SelectedIndex = 0;
            HoleDepth.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Tables.getParametersOfSurfacesAfterVariousOperations().insertListOfOperationsInTreeView(this);
            }
            catch { MessageBox.Show("Повреждены XML таблицы", "Ошибка"); }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EventClickOnButtonOfSelectOperationsOrWorkpiece.buttonOfSelectOperations(e, this);
            }
            catch { MessageBox.Show("button1_Click", "W"); }
        }
        
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try {
                EventClickOfMouseOnTreeViewNode.clickOnTreeOperations(e, this);
            }
            catch { MessageBox.Show("Повреждены XML таблицы", "Ошибка"); }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            EventClickOnButtonOfSelectWorkpriece.buttonSelectWorkpriece(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                EventClickOnButtonOfDeleteOperation.buttonDeleteOperation(this);
            }
            catch { }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                EventClickOnButtonOfCalculationPart.buttonOfCalculation(this);
            }
            catch { }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (TypeOfPart.SelectedIndex == 0) { HoleDepth.Visible = false; label17.Visible = false; } else { label17.Visible = true; HoleDepth.Visible = true; }
        }
        
        private void открытьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOfWorkWithDatabase formOfWorkWithDatabase = new FormOfWorkWithDatabase("", this);
            formOfWorkWithDatabase.ShowDialog();
                TreeOfOperations.Enabled = true;
                TreeOfSelectedOperations.Enabled = true;
                TypeOfMachining.Enabled = true;
                ChoiceOfOperation.Enabled = true;
                Backspace.Enabled = true;
                CalculationOfSchema.Enabled = true;
                TypeOfInstrument.Enabled = true;
                addSurfaceButton.Enabled = true;
                delSurfaceButton.Enabled = true;
                SurfacesTreeView.Enabled = true;
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Длина детали";
            toolTip1.SetToolTip(LengthOfPart, "Введите длину детали");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Размер Диаметр";
            toolTip1.SetToolTip(DiameterOfPart, "Размер Диаметр");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Тип размера";
            toolTip1.SetToolTip(TypeOfPart, "Тип размера");
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Тип припуска";
            toolTip1.SetToolTip(TypeOfAllowance, "Двухсторонний: обрабатываются вал, отверстие, противолежащие поверхности. \nОдносторонний: получаемый размер задаётся от необрабатываемой поверхности.");
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;

            toolTip1.ToolTipTitle = "Тип обрабатываемой поверхности";
            toolTip1.SetToolTip(TypeOfProcessedSurface, "Фасонные замкнутые поверхности следует рассматривать как цилиндрические, фасонные незамкнутые – как плоские.");
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            toolTip1.ToolTipIcon = ToolTipIcon.Warning;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Тип приспособления";
            toolTip1.SetToolTip(TypeOfInstrument, "Тип приспособления");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int nom = Allowance.Text.Length;
                if (Allowance.Text[nom - 1].Equals('.')) { Allowance.Text = Allowance.Text.Replace('.', ','); Allowance.SelectionStart = nom; }
            }
            catch { }
        }

        private void KeyPressForTextBoxWithDouble(object sender, KeyPressEventArgs e)
        {
            try
            {
                EventKeyPressForTextBox.keyPressForTextBoxWithDouble(sender, e);
            }
            catch { }
        }

        private void textRa_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (TypeOfAllowance.Text == "двухсторонний") { pictureBox1.Visible = true; pictureBox2.Visible = false; };
            if (TypeOfAllowance.Text == "односторонний") { pictureBox1.Visible = false; pictureBox2.Visible = true; };
        }

        private void TreeOfSelectedOperations_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EventClickOfMouseOnTreeViewNodeSelectedOperations.clickOnNode(e, this);
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            EventClickOnButtonOfSaveChanges.buttonOfSaveChanges(e, this);
        }

        private void TreeOfSelectedOperations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            EventTreeViewAfterSelectOperations.alferSelect(this, (TreeView)sender, e);
        }

        private void SurfacesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EventClickOfMouseOnSurfacesTreeView.clickOnNode(e, this);
        }

        private void delSurfaceButton_Click(object sender, EventArgs e)
        {
            EventDelSurfaceButton.buttonDelSurface(e, this);
        }

        private void addSurfaceButton_Click(object sender, EventArgs e)
        {
            EventAddSurfaceButton.buttonAddSurface(e, this);
        }

        private void SelectTechnologicalProcess_Click(object sender, EventArgs e)
        {
            try
            {
                EventClickOnButtonOfSelectTechnologicalProcess.buttonSelectProcess(this);
            }
            catch {}
        }

        private void NameSurface_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int indexSelectedSurface = StorageOfSelectedOperation.getIndexSelectedSurface();
                string nameSurface = NameSurface.Text;

                SurfacesTreeView.Nodes[indexSelectedSurface].Text = nameSurface;
                Part.setNameSurfaceOnIndex(indexSelectedSurface, nameSurface);

            }
            catch { }
        }

        private void выборПодключенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            DataConnectionDialog dcd = new DataConnectionDialog();
            DataConnectionConfiguration dcs = new DataConnectionConfiguration(null);
            dcs.LoadConfiguration(dcd);
            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
                connectionString = dcd.ConnectionString;
            dcs.SaveConfiguration(dcd);
           // return connectionString;
        }
    }
}
        

        

        
    

