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
    public partial class MainForm : Form
    {
      
         Form4 z = new Form4("");

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
                double[] d = Part.getSurfaceOnIndex(0).getResultsOfCalculation().getSizeOfWorkprieceAfterOperation();

                foreach (double g in d)
                {
                    richTextBox1.Text += g.ToString() + "  ";
                }
            }
            catch { }
            
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

        private void buttontext_Click(object sender, EventArgs e)
        {

           /* System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"textfile.txt");
        //Последовательность переходов

            textFile.WriteLine();
            textFile.WriteLine("Последовательность переходов");
            textFile.WriteLine(l);
            
            // Исходые данные
            textFile.WriteLine();
            textFile.WriteLine("");
            textFile.WriteLine(l2);
            //
            textFile.Close();*/
        
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (TypeOfPart.SelectedIndex == 0) { HoleDepth.Visible = false; label17.Visible = false; } else { label17.Visible = true; HoleDepth.Visible = true; }
        }
        
        private void открытьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // try
            //{
                //  Hide();
                z.ShowDialog();
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
                //stroka = z.Data;

                /*split_data1 = stroka.Split(new Char[] { '-' });


                DiameterOfPart.Text = split_data1[1]; LengthOfPart.Text = split_data1[0];
                per[0] = "0 - " + split_data1[2]; NameOfWorkpiece.Text = split_data1[2];
                Rz[0] = Convert.ToDouble(split_data1[3]); h[0] = Convert.ToDouble(split_data1[4]); T[0] = Convert.ToDouble(split_data1[5]);
                id[0] = split_data1[7][0];
                Pcm = Convert.ToDouble(split_data1[6]);
                prib[0] = " ";
                id_per[0] = 0;
                richTextBox1.Text = per[0] + "";

                l = per[0] + "";

                i = Convert.ToInt32(split_data1[8]) - 1;
                Array.Resize(ref Rz, i); Array.Resize(ref h, i); Array.Resize(ref T, i); Array.Resize(ref CombInd, i); Array.Resize(ref per, i); Array.Resize(ref K, i); Array.Resize(ref E1, i); Array.Resize(ref E, i); Array.Resize(ref prib, i); Array.Resize(ref per, i); Array.Resize(ref id, i); Array.Resize(ref id_per, i); Array.Resize(ref Epr, i);
                int hhn = 0; Epr[0] = false; CombInd[0] = 0;
                int nom1 = t1.Length / 12;
                for (int yu = 0; yu < nom1; yu++)
                {
                    if (t1[yu, 0][0] != ' ')
                    {
                        hhn++; Array.Resize(ref hh, hhn); Array.Resize(ref mas1, hhn);
                        hh[hhn - 1] = t1[yu, 0]; mas1[hhn - 1] = yu;

                    }
                }



                for (int u = 1; u < i; u++)
                {


                    Rz[u] = Convert.ToDouble(split_data1[10 + (7 * (u - 1))]);
                    h[u] = Convert.ToDouble(split_data1[11 + (7 * (u - 1))]);
                    T[u] = Convert.ToDouble(split_data1[12 + (7 * (u - 1))]);
                    K[u] = Convert.ToDouble(split_data1[13 + (7 * (u - 1))]);
                    CombInd[u] = Convert.ToInt32(split_data1[14 + (7 * (u - 1))]);
                    id[u] = (split_data1[15 + (7 * (u - 1))])[0];
                    if (CombInd[u] == 0) { CombInd[u] = CombInd[u - 1]; }
                    if (CombInd[u] == CombInd[u - 1]) { Epr[u] = false; } else { Epr[u] = true; }
                    prib[u] = hh[CombInd[u]];
                    split_data2 = split_data1[9 + (7 * (u - 1))].Split(new Char[] { ',' });
                    per[u] = Convert.ToString(u) + " - " + split_data2[0] + "(" + split_data2[1] + "," + prib[u] + ")";
                    richTextBox1.Text = richTextBox1.Text + "," + "\n" + per[u];
                    l = l + "," + "\r\n" + per[u];
                }
                //    h[u] = Convert.ToDouble(split_data1[11 + (7 * (u - 1))]);
                string tip_det = split_data1[11 + (7 * (i - 1))];

                if (tip_det.Contains("двухсторонний"))
                { TypeOfAllowance.SelectedIndex = 0;      }

                else { TypeOfAllowance.SelectedIndex = 1;           }
                tip_det = split_data1[10 + (7 * (i - 1))];



                if (tip_det.Contains("цилиндрическая"))
                { TypeOfProcessedSurface.SelectedIndex = 0; }
                else { TypeOfProcessedSurface.SelectedIndex = 1; }
                tip_det = split_data1[9 + (7 * (i - 1))];


                if (tip_det.Contains("вал"))
                { TypeOfPart.SelectedIndex = 0; }
                else { TypeOfPart.SelectedIndex = 1; }
                HoleDepth.Text = split_data1[12 + (7 * (i - 1))];
                for (int u = 1; u < i; u++)
                {
                    for (nom1 = mas1[CombInd[u]]; nom1 < mas1[CombInd[u] + 1]; nom1++)
                    {
                        int hh_dlin = t1[nom1, 1].Length;
                        for (int nom2 = 0; nom2 < hh_dlin; nom2++)
                        {
                            if (t1[nom1, 1][nom2].Equals(id[u - 1]))
                            {

                                E1[u] = nom1;
                            }
                        }
                    }

                }


            }
            catch
            {
                TreeOfOperations.Enabled = false;
                richTextBox1.Enabled = false;
                SurfaceRoughnessRz.Enabled = false;
                ThicknessOfDefectiveCoating.Enabled = false;
                Kvalitet.Enabled = false;
                PrecisionOfMachining.Enabled = false;
                TypeOfMachining.Enabled = false;
                CoefficientOfRefinement.Enabled = false;
                ChoiceOfOperation.Enabled = false;
                Backspace.Enabled = false;
                CalculationOfSchema.Enabled = false;
                TypeOfInstrument.Enabled = false;
                richTextBox2.Enabled = false;
                SurfaceRoughnessRa.Enabled = false;
                buttontext.Enabled = false;
            }*/
            
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
        

        

        
    

