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
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            TypeOfPart.Items.AddRange(new string[] { "вал", "отверстие" });
            TypeOfProcessedSurface.Items.AddRange(new string[] { "цилиндрическая", "плоская" });
            TypeOfAllowance.Items.AddRange(new string[] { "двухсторонний", "односторонний" });

            TypeOfPart.SelectedIndex = 0;
            TypeOfProcessedSurface.SelectedIndex = 0;
            TypeOfAllowance.SelectedIndex = 0;
            HoleDepth.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string xmlpath = @"XMLFiles/ParametersOfSurfacesAfterVariousOperations.xml";
                XMLtoTreeView.formationTreeView(xmlpath, TreeOfOperations);
            }
            catch { MessageBox.Show("Повреждены XML таблицы", "Ошибка"); }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                EventClickOnButtonOfSelectOperationsOrWorkpiece.buttonOfSelectOperations(e, this);
            }
            catch { }
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
           /* try
            {
                if (i > 1)
                {
                    i--;
                    richTextBox1.Text = "";
                    l = "";
                    if (i == 1)
                    {

                        richTextBox1.Text = "";
                        l = "";
                        richTextBox1.Text = richTextBox1.Text + per[0];
                        l = l + per[0];
                    }
                    else { 
                    for (int nom = 0; nom <= i-2; nom++)
                    { richTextBox1.Text = richTextBox1.Text + per[nom]+",\n";
                      l=l + per[nom] + ",\r\n";
                        }
                        richTextBox1.Text = richTextBox1.Text + per[i-1] ;
                        l = l + per[i-1] ;
                    }
                }
                
            }
            catch
            { }*/ }
        
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                EventClickOnButtonOfCalculationPart.buttonOfCalculation(this);
                FormResult form1 = new FormResult();
                form1.ShowDialog();
            }
            catch { }


          /* 
                EventClickOnButtonOfCalculationPart.buttonOfCalculation(this);
                double[] d = Part.getSurfaceOnIndex(0).getResultsOfCalculation().getSizeOfWorkprieceAfterOperation();
                richTextBox1.Clear();
                for(int i = 0; i <= Part.getSurfaceOnIndex(0).getNumberOfOperations(); i++)
                {
                    ClassesToCalculate.ResultsOfCalculation f = Part.getSurfaceOnIndex(0).getResultsOfCalculation();
                    
                    richTextBox1.Text = richTextBox1.Text + "\n" + "__________" + i.ToString() + "______\n";
                    richTextBox1.Text += " E= " + f.getdeviationOfInstallation()[i].ToString() + "\n P= " + f.getSpatialDeviation()[i].ToString() + "\n Znom= " + f.getNominalAllowance()[i].ToString() + "\n Size= " + f.getSizeOfWorkprieceAfterOperation()[i].ToString();
                }
            
            */

            /* // Округление 
             Zmin[nom1] = Math.Round(Zmin[nom1], 4);
             /// my
             Zmind[nom1 - 1] = Convert.ToString(Zmin[nom1]);
             */
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SurfaceRoughnessRa.Text = ConversionRoughnessRzAndRa.stringRzToRa(SurfaceRoughnessRz.Text);
            }
            catch { SurfaceRoughnessRa.Text = ""; }
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
                richTextBox1.Enabled = true;
                SurfaceRoughnessRz.Enabled = true;
        
                PrecisionOfMachining.Enabled = true;
                TypeOfMachining.Enabled = true;
                ChoiceOfOperation.Enabled = true;
                Backspace.Enabled = true;
                CalculationOfSchema.Enabled = true;
                TypeOfInstrument.Enabled = true;
                SurfaceRoughnessRa.Enabled = true;
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
           //     if (textBox3.Text[nom - 1].Equals('-')) { textBox3.Text = textBox3.Text.Replace('-', '' ); textBox3.SelectionStart = nom; }
            //    if (textBox3.Text[nom - 1].Equals('+')) { textBox3.Text = textBox3.Text.Replace('+', '' ); textBox3.SelectionStart = nom; }


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
            try
            {
                SurfaceRoughnessRz.Text = ConversionRoughnessRzAndRa.stringRaToRz(SurfaceRoughnessRa.Text);
            }
            catch { SurfaceRoughnessRz.Text = ""; }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            if (TypeOfAllowance.Text == "двухсторонний") { pictureBox1.Visible = true; pictureBox2.Visible = false; };
            if (TypeOfAllowance.Text == "односторонний") { pictureBox1.Visible = false; pictureBox2.Visible = true; };
        }

        private void textBox5_Click(object sender, EventArgs e)
       {
            try {
                Interval recommendedIntervalRz = StorageOfSelectedOperation.getParameters().getRecommendedIntervalRz();
                string minRz = recommendedIntervalRz.getIntervalMinConvertToString();
                string maxRz = recommendedIntervalRz.getIntervalMaxConvertToString();
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipTitle = "Достигаемая шероховатость, Rz, мм";
                toolTip1.SetToolTip(SurfaceRoughnessRz, "Интервал для данной операции: " + Convert.ToString(minRz) + "..." + Convert.ToString(maxRz));
            }
            catch { }

        }

        private void textRa_Click(object sender, EventArgs e)
        {
            try
            {
                Interval recommendedIntervalRz = StorageOfSelectedOperation.getParameters().getRecommendedIntervalRz();
                Interval recommendedIntervalRa = ConversionRoughnessRzAndRa.intervalRzToIntervalRa(recommendedIntervalRz);
                string minRa = recommendedIntervalRa.getIntervalMinConvertToString();
                string maxRa = recommendedIntervalRa.getIntervalMaxConvertToString();
                toolTip1.ToolTipIcon = ToolTipIcon.Warning;
                toolTip1.IsBalloon = true;
                toolTip1.ToolTipTitle = "Достигаемая шероховатость, Ra, мкм";
                toolTip1.SetToolTip(SurfaceRoughnessRa, "Интервал для данной операции: " + Convert.ToString(minRa) + "..." + Convert.ToString(maxRa));
            }
            catch { }
        }
    }
}
        

        

        
    

