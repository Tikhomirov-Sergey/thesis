﻿namespace WindowsFormsApplication8
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Тех.процесс");
            this.label1 = new System.Windows.Forms.Label();
            this.DiameterOfPart = new System.Windows.Forms.TextBox();
            this.TypeOfPart = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeOfProcessedSurface = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeOfAllowance = new System.Windows.Forms.ComboBox();
            this.TreeOfOperations = new System.Windows.Forms.TreeView();
            this.ChoiceOfOperation = new System.Windows.Forms.Button();
            this.SurfaceRoughnessRz = new System.Windows.Forms.TextBox();
            this.ThicknessOfDefectiveCoating = new System.Windows.Forms.TextBox();
            this.Kvalitet = new System.Windows.Forms.TextBox();
            this.ChoiceOfWorkpiece = new System.Windows.Forms.Button();
            this.PrecisionOfMachining = new System.Windows.Forms.TextBox();
            this.TypeOfMachining = new System.Windows.Forms.TextBox();
            this.NameOfWorkpiece = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Ra = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Backspace = new System.Windows.Forms.Button();
            this.CoefficientOfRefinement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LengthOfPart = new System.Windows.Forms.TextBox();
            this.TypeOfInstrument = new System.Windows.Forms.ComboBox();
            this.CalculationOfSchema = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.HoleDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SurfaceRoughnessRa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Allowance = new System.Windows.Forms.TextBox();
            this.TreeOfSelectedOperations = new System.Windows.Forms.TreeView();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.addSurfaceButton = new System.Windows.Forms.Button();
            this.delSurfaceButton = new System.Windows.Forms.Button();
            this.SurfacesTreeView = new System.Windows.Forms.TreeView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Surfaces = new System.Windows.Forms.Label();
            this.editProcessButton = new System.Windows.Forms.Button();
            this.editSurfacesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обрабатываемый размер/Диаметр (L/d,мм):";
            // 
            // DiameterOfPart
            // 
            this.DiameterOfPart.Location = new System.Drawing.Point(247, 60);
            this.DiameterOfPart.Name = "DiameterOfPart";
            this.DiameterOfPart.Size = new System.Drawing.Size(62, 20);
            this.DiameterOfPart.TabIndex = 1;
            this.DiameterOfPart.Click += new System.EventHandler(this.textBox1_Click);
            this.DiameterOfPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // TypeOfPart
            // 
            this.TypeOfPart.FormattingEnabled = true;
            this.TypeOfPart.Location = new System.Drawing.Point(88, 89);
            this.TypeOfPart.Name = "TypeOfPart";
            this.TypeOfPart.Size = new System.Drawing.Size(143, 21);
            this.TypeOfPart.TabIndex = 8;
            this.TypeOfPart.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.TypeOfPart.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип размера:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип обрабатываемой  поверхности:";
            // 
            // TypeOfProcessedSurface
            // 
            this.TypeOfProcessedSurface.FormattingEnabled = true;
            this.TypeOfProcessedSurface.Location = new System.Drawing.Point(199, 147);
            this.TypeOfProcessedSurface.Name = "TypeOfProcessedSurface";
            this.TypeOfProcessedSurface.Size = new System.Drawing.Size(110, 21);
            this.TypeOfProcessedSurface.TabIndex = 11;
            this.TypeOfProcessedSurface.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Тип припуска:";
            // 
            // TypeOfAllowance
            // 
            this.TypeOfAllowance.FormattingEnabled = true;
            this.TypeOfAllowance.Location = new System.Drawing.Point(88, 116);
            this.TypeOfAllowance.Name = "TypeOfAllowance";
            this.TypeOfAllowance.Size = new System.Drawing.Size(143, 21);
            this.TypeOfAllowance.TabIndex = 13;
            this.TypeOfAllowance.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            this.TypeOfAllowance.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // TreeOfOperations
            // 
            this.TreeOfOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeOfOperations.Enabled = false;
            this.TreeOfOperations.Location = new System.Drawing.Point(12, 335);
            this.TreeOfOperations.Name = "TreeOfOperations";
            this.TreeOfOperations.ShowLines = false;
            this.TreeOfOperations.ShowPlusMinus = false;
            this.TreeOfOperations.ShowRootLines = false;
            this.TreeOfOperations.Size = new System.Drawing.Size(400, 179);
            this.TreeOfOperations.TabIndex = 16;
            this.TreeOfOperations.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // ChoiceOfOperation
            // 
            this.ChoiceOfOperation.Enabled = false;
            this.ChoiceOfOperation.Location = new System.Drawing.Point(875, 143);
            this.ChoiceOfOperation.Name = "ChoiceOfOperation";
            this.ChoiceOfOperation.Size = new System.Drawing.Size(98, 181);
            this.ChoiceOfOperation.TabIndex = 17;
            this.ChoiceOfOperation.Text = "Выбор переходов";
            this.ChoiceOfOperation.UseVisualStyleBackColor = true;
            this.ChoiceOfOperation.Click += new System.EventHandler(this.button1_Click);
            // 
            // SurfaceRoughnessRz
            // 
            this.SurfaceRoughnessRz.Enabled = false;
            this.SurfaceRoughnessRz.Location = new System.Drawing.Point(635, 195);
            this.SurfaceRoughnessRz.Name = "SurfaceRoughnessRz";
            this.SurfaceRoughnessRz.Size = new System.Drawing.Size(85, 20);
            this.SurfaceRoughnessRz.TabIndex = 18;
            this.SurfaceRoughnessRz.Click += new System.EventHandler(this.textBox5_Click);
            this.SurfaceRoughnessRz.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.SurfaceRoughnessRz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // ThicknessOfDefectiveCoating
            // 
            this.ThicknessOfDefectiveCoating.Enabled = false;
            this.ThicknessOfDefectiveCoating.Location = new System.Drawing.Point(635, 225);
            this.ThicknessOfDefectiveCoating.Name = "ThicknessOfDefectiveCoating";
            this.ThicknessOfDefectiveCoating.Size = new System.Drawing.Size(234, 20);
            this.ThicknessOfDefectiveCoating.TabIndex = 19;
            this.ThicknessOfDefectiveCoating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // Kvalitet
            // 
            this.Kvalitet.Enabled = false;
            this.Kvalitet.Location = new System.Drawing.Point(635, 251);
            this.Kvalitet.Name = "Kvalitet";
            this.Kvalitet.Size = new System.Drawing.Size(234, 20);
            this.Kvalitet.TabIndex = 20;
            this.Kvalitet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // ChoiceOfWorkpiece
            // 
            this.ChoiceOfWorkpiece.BackColor = System.Drawing.SystemColors.Control;
            this.ChoiceOfWorkpiece.Location = new System.Drawing.Point(635, 50);
            this.ChoiceOfWorkpiece.Name = "ChoiceOfWorkpiece";
            this.ChoiceOfWorkpiece.Size = new System.Drawing.Size(464, 84);
            this.ChoiceOfWorkpiece.TabIndex = 22;
            this.ChoiceOfWorkpiece.Text = "Выбор заготовки";
            this.ChoiceOfWorkpiece.UseVisualStyleBackColor = false;
            this.ChoiceOfWorkpiece.Click += new System.EventHandler(this.button2_Click);
            // 
            // PrecisionOfMachining
            // 
            this.PrecisionOfMachining.Enabled = false;
            this.PrecisionOfMachining.Location = new System.Drawing.Point(635, 169);
            this.PrecisionOfMachining.Name = "PrecisionOfMachining";
            this.PrecisionOfMachining.Size = new System.Drawing.Size(234, 20);
            this.PrecisionOfMachining.TabIndex = 23;
            // 
            // TypeOfMachining
            // 
            this.TypeOfMachining.Enabled = false;
            this.TypeOfMachining.Location = new System.Drawing.Point(635, 143);
            this.TypeOfMachining.Name = "TypeOfMachining";
            this.TypeOfMachining.Size = new System.Drawing.Size(234, 20);
            this.TypeOfMachining.TabIndex = 24;
            // 
            // NameOfWorkpiece
            // 
            this.NameOfWorkpiece.Enabled = false;
            this.NameOfWorkpiece.Location = new System.Drawing.Point(698, 24);
            this.NameOfWorkpiece.Name = "NameOfWorkpiece";
            this.NameOfWorkpiece.Size = new System.Drawing.Size(401, 20);
            this.NameOfWorkpiece.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Заготовка";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Достигаемая шероховатость, Rz, мм";
            // 
            // Ra
            // 
            this.Ra.AutoSize = true;
            this.Ra.Location = new System.Drawing.Point(726, 198);
            this.Ra.Name = "Ra";
            this.Ra.Size = new System.Drawing.Size(49, 13);
            this.Ra.TabIndex = 28;
            this.Ra.Text = "Ra, мкм";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(489, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Достигаемая точность, IT";
            // 
            // Backspace
            // 
            this.Backspace.Enabled = false;
            this.Backspace.Location = new System.Drawing.Point(979, 143);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(120, 85);
            this.Backspace.TabIndex = 30;
            this.Backspace.Text = "Backspace";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // CoefficientOfRefinement
            // 
            this.CoefficientOfRefinement.Enabled = false;
            this.CoefficientOfRefinement.Location = new System.Drawing.Point(635, 277);
            this.CoefficientOfRefinement.Name = "CoefficientOfRefinement";
            this.CoefficientOfRefinement.Size = new System.Drawing.Size(234, 20);
            this.CoefficientOfRefinement.TabIndex = 31;
            this.CoefficientOfRefinement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(481, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Коэффициент уточнения, ky";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Длина детали (l,мм):";
            // 
            // LengthOfPart
            // 
            this.LengthOfPart.Location = new System.Drawing.Point(120, 37);
            this.LengthOfPart.Name = "LengthOfPart";
            this.LengthOfPart.Size = new System.Drawing.Size(59, 20);
            this.LengthOfPart.TabIndex = 37;
            this.LengthOfPart.Click += new System.EventHandler(this.textBox12_Click);
            this.LengthOfPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // TypeOfInstrument
            // 
            this.TypeOfInstrument.Enabled = false;
            this.TypeOfInstrument.FormattingEnabled = true;
            this.TypeOfInstrument.Location = new System.Drawing.Point(635, 303);
            this.TypeOfInstrument.Name = "TypeOfInstrument";
            this.TypeOfInstrument.Size = new System.Drawing.Size(234, 21);
            this.TypeOfInstrument.TabIndex = 38;
            this.TypeOfInstrument.Click += new System.EventHandler(this.comboBox5_Click);
            // 
            // CalculationOfSchema
            // 
            this.CalculationOfSchema.Enabled = false;
            this.CalculationOfSchema.Location = new System.Drawing.Point(438, 479);
            this.CalculationOfSchema.Name = "CalculationOfSchema";
            this.CalculationOfSchema.Size = new System.Drawing.Size(661, 35);
            this.CalculationOfSchema.TabIndex = 39;
            this.CalculationOfSchema.Text = "Расчёт размерной цепи";
            this.CalculationOfSchema.UseVisualStyleBackColor = true;
            this.CalculationOfSchema.Click += new System.EventHandler(this.button4_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Глубина отверстия (lo,мм):";
            // 
            // HoleDepth
            // 
            this.HoleDepth.Location = new System.Drawing.Point(151, 174);
            this.HoleDepth.Name = "HoleDepth";
            this.HoleDepth.Size = new System.Drawing.Size(158, 20);
            this.HoleDepth.TabIndex = 44;
            this.HoleDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Вид обработки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Тип приспособления";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "Открыть бд";
            // 
            // открытьБДToolStripMenuItem
            // 
            this.открытьБДToolStripMenuItem.Name = "открытьБДToolStripMenuItem";
            this.открытьБДToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.открытьБДToolStripMenuItem.Text = "Открыть БД";
            this.открытьБДToolStripMenuItem.Click += new System.EventHandler(this.открытьБДToolStripMenuItem_Click);
            // 
            // SurfaceRoughnessRa
            // 
            this.SurfaceRoughnessRa.Enabled = false;
            this.SurfaceRoughnessRa.Location = new System.Drawing.Point(779, 195);
            this.SurfaceRoughnessRa.Name = "SurfaceRoughnessRa";
            this.SurfaceRoughnessRa.Size = new System.Drawing.Size(90, 20);
            this.SurfaceRoughnessRa.TabIndex = 51;
            this.SurfaceRoughnessRa.Click += new System.EventHandler(this.textRa_Click);
            this.SurfaceRoughnessRa.TextChanged += new System.EventHandler(this.textRa_TextChanged);
            this.SurfaceRoughnessRa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Глубина дефектного слоя, мм";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(315, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 199);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Допуск, мкм (без знака)";
            // 
            // Allowance
            // 
            this.Allowance.Location = new System.Drawing.Point(137, 197);
            this.Allowance.Margin = new System.Windows.Forms.Padding(2);
            this.Allowance.Name = "Allowance";
            this.Allowance.Size = new System.Drawing.Size(76, 20);
            this.Allowance.TabIndex = 57;
            this.Allowance.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Allowance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // TreeOfSelectedOperations
            // 
            this.TreeOfSelectedOperations.BackColor = System.Drawing.SystemColors.Window;
            this.TreeOfSelectedOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeOfSelectedOperations.Enabled = false;
            this.TreeOfSelectedOperations.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TreeOfSelectedOperations.Location = new System.Drawing.Point(438, 332);
            this.TreeOfSelectedOperations.Name = "TreeOfSelectedOperations";
            this.TreeOfSelectedOperations.Size = new System.Drawing.Size(661, 141);
            this.TreeOfSelectedOperations.TabIndex = 58;
            this.TreeOfSelectedOperations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeOfSelectedOperations_AfterSelect);
            this.TreeOfSelectedOperations.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeOfSelectedOperations_NodeMouseClick);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(979, 234);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(120, 90);
            this.SaveChanges.TabIndex = 59;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // addSurfaceButton
            // 
            this.addSurfaceButton.Location = new System.Drawing.Point(373, 234);
            this.addSurfaceButton.Name = "addSurfaceButton";
            this.addSurfaceButton.Size = new System.Drawing.Size(36, 33);
            this.addSurfaceButton.TabIndex = 61;
            this.addSurfaceButton.Text = "+";
            this.addSurfaceButton.UseVisualStyleBackColor = true;
            this.addSurfaceButton.Click += new System.EventHandler(this.addSurfaceButton_Click);
            // 
            // delSurfaceButton
            // 
            this.delSurfaceButton.Location = new System.Drawing.Point(373, 269);
            this.delSurfaceButton.Name = "delSurfaceButton";
            this.delSurfaceButton.Size = new System.Drawing.Size(36, 33);
            this.delSurfaceButton.TabIndex = 62;
            this.delSurfaceButton.Text = "-";
            this.delSurfaceButton.UseVisualStyleBackColor = true;
            this.delSurfaceButton.Click += new System.EventHandler(this.delSurfaceButton_Click);
            // 
            // SurfacesTreeView
            // 
            this.SurfacesTreeView.Location = new System.Drawing.Point(9, 234);
            this.SurfacesTreeView.Name = "SurfacesTreeView";
            treeNode1.Name = "technologicalProcess";
            treeNode1.Text = "Тех.процесс";
            this.SurfacesTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.SurfacesTreeView.Size = new System.Drawing.Size(358, 68);
            this.SurfacesTreeView.TabIndex = 60;
            this.SurfacesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SurfacesTreeView_NodeMouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Дерево операций",
            "Тех. процесс"});
            this.comboBox1.Location = new System.Drawing.Point(9, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 63;
            // 
            // Surfaces
            // 
            this.Surfaces.AutoSize = true;
            this.Surfaces.Location = new System.Drawing.Point(154, 219);
            this.Surfaces.Name = "Surfaces";
            this.Surfaces.Size = new System.Drawing.Size(73, 13);
            this.Surfaces.TabIndex = 64;
            this.Surfaces.Text = "Поверхности";
            // 
            // editProcessButton
            // 
            this.editProcessButton.Location = new System.Drawing.Point(187, 306);
            this.editProcessButton.Name = "editProcessButton";
            this.editProcessButton.Size = new System.Drawing.Size(222, 23);
            this.editProcessButton.TabIndex = 65;
            this.editProcessButton.Text = "редактирование тех. процесса";
            this.editProcessButton.UseVisualStyleBackColor = true;
            this.editProcessButton.Visible = false;
            this.editProcessButton.Click += new System.EventHandler(this.editProcessButton_Click);
            // 
            // editSurfacesButton
            // 
            this.editSurfacesButton.Location = new System.Drawing.Point(187, 306);
            this.editSurfacesButton.Name = "editSurfacesButton";
            this.editSurfacesButton.Size = new System.Drawing.Size(222, 23);
            this.editSurfacesButton.TabIndex = 66;
            this.editSurfacesButton.Text = "редактирование поверхностей";
            this.editSurfacesButton.UseVisualStyleBackColor = true;
            this.editSurfacesButton.Click += new System.EventHandler(this.editSurfacesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 521);
            this.Controls.Add(this.editSurfacesButton);
            this.Controls.Add(this.editProcessButton);
            this.Controls.Add(this.Surfaces);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delSurfaceButton);
            this.Controls.Add(this.addSurfaceButton);
            this.Controls.Add(this.SurfacesTreeView);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.TreeOfSelectedOperations);
            this.Controls.Add(this.Allowance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurfaceRoughnessRa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoleDepth);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CalculationOfSchema);
            this.Controls.Add(this.TypeOfInstrument);
            this.Controls.Add(this.LengthOfPart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CoefficientOfRefinement);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Ra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NameOfWorkpiece);
            this.Controls.Add(this.TypeOfMachining);
            this.Controls.Add(this.PrecisionOfMachining);
            this.Controls.Add(this.ChoiceOfWorkpiece);
            this.Controls.Add(this.Kvalitet);
            this.Controls.Add(this.ThicknessOfDefectiveCoating);
            this.Controls.Add(this.SurfaceRoughnessRz);
            this.Controls.Add(this.ChoiceOfOperation);
            this.Controls.Add(this.TreeOfOperations);
            this.Controls.Add(this.TypeOfAllowance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TypeOfProcessedSurface);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TypeOfPart);
            this.Controls.Add(this.DiameterOfPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Расчёт размерной цепи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Ra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьБДToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.Button CalculationOfSchema;
        protected internal System.Windows.Forms.Button ChoiceOfWorkpiece;
        protected internal System.Windows.Forms.TextBox HoleDepth;
        protected internal System.Windows.Forms.TextBox DiameterOfPart;
        protected internal System.Windows.Forms.ComboBox TypeOfAllowance;
        protected internal System.Windows.Forms.TextBox LengthOfPart;
        protected internal System.Windows.Forms.ComboBox TypeOfPart;
        protected internal System.Windows.Forms.ComboBox TypeOfProcessedSurface;
        protected internal System.Windows.Forms.TextBox TypeOfMachining;
        protected internal System.Windows.Forms.TextBox SurfaceRoughnessRz;
        protected internal System.Windows.Forms.TextBox SurfaceRoughnessRa;
        protected internal System.Windows.Forms.TextBox Allowance;
        protected internal System.Windows.Forms.ComboBox TypeOfInstrument;
        protected internal System.Windows.Forms.TextBox ThicknessOfDefectiveCoating;
        protected internal System.Windows.Forms.TextBox Kvalitet;
        protected internal System.Windows.Forms.TextBox PrecisionOfMachining;
        protected internal System.Windows.Forms.TextBox CoefficientOfRefinement;
        protected internal System.Windows.Forms.TextBox NameOfWorkpiece;
        protected internal System.Windows.Forms.TreeView TreeOfOperations;
        protected internal System.Windows.Forms.Button ChoiceOfOperation;
        protected internal System.Windows.Forms.Button Backspace;
        protected internal System.Windows.Forms.TreeView TreeOfSelectedOperations;
        protected internal System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Button addSurfaceButton;
        private System.Windows.Forms.Button delSurfaceButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Surfaces;
        private System.Windows.Forms.Button editProcessButton;
        private System.Windows.Forms.Button editSurfacesButton;
        public System.Windows.Forms.TreeView SurfacesTreeView;
    }
}

