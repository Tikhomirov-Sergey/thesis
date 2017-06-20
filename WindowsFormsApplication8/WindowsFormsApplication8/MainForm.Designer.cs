namespace WindowsFormsApplication8
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
            this.LabelDiameterOfPart = new System.Windows.Forms.Label();
            this.DiameterOfPart = new System.Windows.Forms.TextBox();
            this.TypeOfPart = new System.Windows.Forms.ComboBox();
            this.LabelTypeOfPart = new System.Windows.Forms.Label();
            this.LabelTypeOfProcessedSurface = new System.Windows.Forms.Label();
            this.TypeOfProcessedSurface = new System.Windows.Forms.ComboBox();
            this.LabelTypeOfAllowance = new System.Windows.Forms.Label();
            this.TypeOfAllowance = new System.Windows.Forms.ComboBox();
            this.TreeOfOperations = new System.Windows.Forms.TreeView();
            this.ChoiceOfOperation = new System.Windows.Forms.Button();
            this.ChoiceOfWorkpiece = new System.Windows.Forms.Button();
            this.TypeOfMachining = new System.Windows.Forms.TextBox();
            this.NameOfWorkpiece = new System.Windows.Forms.TextBox();
            this.LabelWorkpiece = new System.Windows.Forms.Label();
            this.Backspace = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.LengthOfPart = new System.Windows.Forms.TextBox();
            this.TypeOfInstrument = new System.Windows.Forms.ComboBox();
            this.CalculationOfSchema = new System.Windows.Forms.Button();
            this.LabelHoleDepth = new System.Windows.Forms.Label();
            this.HoleDepth = new System.Windows.Forms.TextBox();
            this.LabelTypeOfMachining = new System.Windows.Forms.Label();
            this.LabelTypeOfInstrument = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выборПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelAllowance = new System.Windows.Forms.Label();
            this.Allowance = new System.Windows.Forms.TextBox();
            this.TreeOfSelectedOperations = new System.Windows.Forms.TreeView();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.addSurfaceButton = new System.Windows.Forms.Button();
            this.delSurfaceButton = new System.Windows.Forms.Button();
            this.SurfacesTreeView = new System.Windows.Forms.TreeView();
            this.Surfaces = new System.Windows.Forms.Label();
            this.SelectTechnologicalProcess = new System.Windows.Forms.Button();
            this.SurfaceRoughness = new System.Windows.Forms.TextBox();
            this.NameSurface = new System.Windows.Forms.TextBox();
            this.LabelRoughness = new System.Windows.Forms.Label();
            this.labelOperationsOrTechProcess = new System.Windows.Forms.Label();
            this.labelOfSelectedOperations = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDiameterOfPart
            // 
            this.LabelDiameterOfPart.AutoSize = true;
            this.LabelDiameterOfPart.Location = new System.Drawing.Point(6, 63);
            this.LabelDiameterOfPart.Name = "LabelDiameterOfPart";
            this.LabelDiameterOfPart.Size = new System.Drawing.Size(238, 13);
            this.LabelDiameterOfPart.TabIndex = 0;
            this.LabelDiameterOfPart.Text = "Обрабатываемый размер/Диаметр (L/d,мм):";
            this.LabelDiameterOfPart.Visible = false;
            // 
            // DiameterOfPart
            // 
            this.DiameterOfPart.Location = new System.Drawing.Point(247, 60);
            this.DiameterOfPart.Name = "DiameterOfPart";
            this.DiameterOfPart.Size = new System.Drawing.Size(62, 20);
            this.DiameterOfPart.TabIndex = 1;
            this.DiameterOfPart.Text = "65";
            this.DiameterOfPart.Visible = false;
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
            this.TypeOfPart.Visible = false;
            this.TypeOfPart.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.TypeOfPart.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // LabelTypeOfPart
            // 
            this.LabelTypeOfPart.AutoSize = true;
            this.LabelTypeOfPart.Location = new System.Drawing.Point(6, 92);
            this.LabelTypeOfPart.Name = "LabelTypeOfPart";
            this.LabelTypeOfPart.Size = new System.Drawing.Size(76, 13);
            this.LabelTypeOfPart.TabIndex = 9;
            this.LabelTypeOfPart.Text = "Тип размера:";
            this.LabelTypeOfPart.Visible = false;
            // 
            // LabelTypeOfProcessedSurface
            // 
            this.LabelTypeOfProcessedSurface.AutoSize = true;
            this.LabelTypeOfProcessedSurface.Location = new System.Drawing.Point(6, 150);
            this.LabelTypeOfProcessedSurface.Name = "LabelTypeOfProcessedSurface";
            this.LabelTypeOfProcessedSurface.Size = new System.Drawing.Size(189, 13);
            this.LabelTypeOfProcessedSurface.TabIndex = 10;
            this.LabelTypeOfProcessedSurface.Text = "Тип обрабатываемой  поверхности:";
            this.LabelTypeOfProcessedSurface.Visible = false;
            // 
            // TypeOfProcessedSurface
            // 
            this.TypeOfProcessedSurface.FormattingEnabled = true;
            this.TypeOfProcessedSurface.Location = new System.Drawing.Point(199, 147);
            this.TypeOfProcessedSurface.Name = "TypeOfProcessedSurface";
            this.TypeOfProcessedSurface.Size = new System.Drawing.Size(110, 21);
            this.TypeOfProcessedSurface.TabIndex = 11;
            this.TypeOfProcessedSurface.Visible = false;
            this.TypeOfProcessedSurface.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // LabelTypeOfAllowance
            // 
            this.LabelTypeOfAllowance.AutoSize = true;
            this.LabelTypeOfAllowance.Location = new System.Drawing.Point(6, 120);
            this.LabelTypeOfAllowance.Name = "LabelTypeOfAllowance";
            this.LabelTypeOfAllowance.Size = new System.Drawing.Size(79, 13);
            this.LabelTypeOfAllowance.TabIndex = 12;
            this.LabelTypeOfAllowance.Text = "Тип припуска:";
            this.LabelTypeOfAllowance.Visible = false;
            // 
            // TypeOfAllowance
            // 
            this.TypeOfAllowance.FormattingEnabled = true;
            this.TypeOfAllowance.Location = new System.Drawing.Point(88, 116);
            this.TypeOfAllowance.Name = "TypeOfAllowance";
            this.TypeOfAllowance.Size = new System.Drawing.Size(143, 21);
            this.TypeOfAllowance.TabIndex = 13;
            this.TypeOfAllowance.Visible = false;
            this.TypeOfAllowance.TextChanged += new System.EventHandler(this.comboBox3_TextChanged);
            this.TypeOfAllowance.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // TreeOfOperations
            // 
            this.TreeOfOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeOfOperations.Enabled = false;
            this.TreeOfOperations.Location = new System.Drawing.Point(8, 163);
            this.TreeOfOperations.Name = "TreeOfOperations";
            this.TreeOfOperations.ShowLines = false;
            this.TreeOfOperations.ShowPlusMinus = false;
            this.TreeOfOperations.ShowRootLines = false;
            this.TreeOfOperations.Size = new System.Drawing.Size(348, 190);
            this.TreeOfOperations.TabIndex = 16;
            this.TreeOfOperations.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // ChoiceOfOperation
            // 
            this.ChoiceOfOperation.Enabled = false;
            this.ChoiceOfOperation.Location = new System.Drawing.Point(277, 52);
            this.ChoiceOfOperation.Name = "ChoiceOfOperation";
            this.ChoiceOfOperation.Size = new System.Drawing.Size(79, 78);
            this.ChoiceOfOperation.TabIndex = 17;
            this.ChoiceOfOperation.Text = "Выбор переходов";
            this.ChoiceOfOperation.UseVisualStyleBackColor = true;
            this.ChoiceOfOperation.Visible = false;
            this.ChoiceOfOperation.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChoiceOfWorkpiece
            // 
            this.ChoiceOfWorkpiece.BackColor = System.Drawing.SystemColors.Control;
            this.ChoiceOfWorkpiece.Location = new System.Drawing.Point(277, 22);
            this.ChoiceOfWorkpiece.Name = "ChoiceOfWorkpiece";
            this.ChoiceOfWorkpiece.Size = new System.Drawing.Size(401, 112);
            this.ChoiceOfWorkpiece.TabIndex = 22;
            this.ChoiceOfWorkpiece.Text = "Выбор заготовки";
            this.ChoiceOfWorkpiece.UseVisualStyleBackColor = false;
            this.ChoiceOfWorkpiece.Click += new System.EventHandler(this.button2_Click);
            // 
            // TypeOfMachining
            // 
            this.TypeOfMachining.Enabled = false;
            this.TypeOfMachining.Location = new System.Drawing.Point(97, 60);
            this.TypeOfMachining.Name = "TypeOfMachining";
            this.TypeOfMachining.Size = new System.Drawing.Size(175, 20);
            this.TypeOfMachining.TabIndex = 24;
            // 
            // NameOfWorkpiece
            // 
            this.NameOfWorkpiece.Enabled = false;
            this.NameOfWorkpiece.Location = new System.Drawing.Point(451, 1);
            this.NameOfWorkpiece.Name = "NameOfWorkpiece";
            this.NameOfWorkpiece.Size = new System.Drawing.Size(228, 20);
            this.NameOfWorkpiece.TabIndex = 25;
            this.NameOfWorkpiece.Visible = false;
            // 
            // LabelWorkpiece
            // 
            this.LabelWorkpiece.AutoSize = true;
            this.LabelWorkpiece.Location = new System.Drawing.Point(388, 3);
            this.LabelWorkpiece.Name = "LabelWorkpiece";
            this.LabelWorkpiece.Size = new System.Drawing.Size(60, 13);
            this.LabelWorkpiece.TabIndex = 26;
            this.LabelWorkpiece.Text = "Заготовка";
            this.LabelWorkpiece.Visible = false;
            // 
            // Backspace
            // 
            this.Backspace.Enabled = false;
            this.Backspace.Location = new System.Drawing.Point(362, 52);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(77, 35);
            this.Backspace.TabIndex = 30;
            this.Backspace.Text = "Backspace";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Visible = false;
            this.Backspace.Click += new System.EventHandler(this.button3_Click_1);
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
            this.LengthOfPart.Text = "53";
            this.LengthOfPart.Click += new System.EventHandler(this.textBox12_Click);
            this.LengthOfPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // TypeOfInstrument
            // 
            this.TypeOfInstrument.Enabled = false;
            this.TypeOfInstrument.FormattingEnabled = true;
            this.TypeOfInstrument.Location = new System.Drawing.Point(128, 98);
            this.TypeOfInstrument.Name = "TypeOfInstrument";
            this.TypeOfInstrument.Size = new System.Drawing.Size(144, 21);
            this.TypeOfInstrument.TabIndex = 38;
            this.TypeOfInstrument.Click += new System.EventHandler(this.comboBox5_Click);
            // 
            // CalculationOfSchema
            // 
            this.CalculationOfSchema.Enabled = false;
            this.CalculationOfSchema.Location = new System.Drawing.Point(438, 522);
            this.CalculationOfSchema.Name = "CalculationOfSchema";
            this.CalculationOfSchema.Size = new System.Drawing.Size(464, 35);
            this.CalculationOfSchema.TabIndex = 39;
            this.CalculationOfSchema.Text = "Расчёт размерной цепи";
            this.CalculationOfSchema.UseVisualStyleBackColor = true;
            this.CalculationOfSchema.Visible = false;
            this.CalculationOfSchema.Click += new System.EventHandler(this.button4_Click);
            // 
            // LabelHoleDepth
            // 
            this.LabelHoleDepth.AutoSize = true;
            this.LabelHoleDepth.Location = new System.Drawing.Point(6, 177);
            this.LabelHoleDepth.Name = "LabelHoleDepth";
            this.LabelHoleDepth.Size = new System.Drawing.Size(142, 13);
            this.LabelHoleDepth.TabIndex = 43;
            this.LabelHoleDepth.Text = "Глубина отверстия (lo,мм):";
            this.LabelHoleDepth.Visible = false;
            // 
            // HoleDepth
            // 
            this.HoleDepth.Location = new System.Drawing.Point(151, 174);
            this.HoleDepth.Name = "HoleDepth";
            this.HoleDepth.Size = new System.Drawing.Size(158, 20);
            this.HoleDepth.TabIndex = 44;
            this.HoleDepth.Visible = false;
            this.HoleDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // LabelTypeOfMachining
            // 
            this.LabelTypeOfMachining.AutoSize = true;
            this.LabelTypeOfMachining.Enabled = false;
            this.LabelTypeOfMachining.Location = new System.Drawing.Point(9, 63);
            this.LabelTypeOfMachining.Name = "LabelTypeOfMachining";
            this.LabelTypeOfMachining.Size = new System.Drawing.Size(82, 13);
            this.LabelTypeOfMachining.TabIndex = 47;
            this.LabelTypeOfMachining.Text = "Вид обработки";
            // 
            // LabelTypeOfInstrument
            // 
            this.LabelTypeOfInstrument.AutoSize = true;
            this.LabelTypeOfInstrument.Enabled = false;
            this.LabelTypeOfInstrument.Location = new System.Drawing.Point(9, 101);
            this.LabelTypeOfInstrument.Name = "LabelTypeOfInstrument";
            this.LabelTypeOfInstrument.Size = new System.Drawing.Size(113, 13);
            this.LabelTypeOfInstrument.TabIndex = 48;
            this.LabelTypeOfInstrument.Text = "Тип приспособления";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьБДToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборПодключенияToolStripMenuItem,
            this.restoreDBToolStripMenuItem,
            this.backupDBToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem1.Text = "Работа с БД";
            // 
            // выборПодключенияToolStripMenuItem
            // 
            this.выборПодключенияToolStripMenuItem.Name = "выборПодключенияToolStripMenuItem";
            this.выборПодключенияToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.выборПодключенияToolStripMenuItem.Text = "Выбор подключения";
            this.выборПодключенияToolStripMenuItem.Click += new System.EventHandler(this.выборПодключенияToolStripMenuItem_Click);
            // 
            // restoreDBToolStripMenuItem
            // 
            this.restoreDBToolStripMenuItem.Name = "restoreDBToolStripMenuItem";
            this.restoreDBToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.restoreDBToolStripMenuItem.Text = "Восстановить БД";
            this.restoreDBToolStripMenuItem.Click += new System.EventHandler(this.restoreDBToolStripMenuItem_Click);
            // 
            // backupDBToolStripMenuItem
            // 
            this.backupDBToolStripMenuItem.Name = "backupDBToolStripMenuItem";
            this.backupDBToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.backupDBToolStripMenuItem.Text = "Бэкап БД";
            this.backupDBToolStripMenuItem.Click += new System.EventHandler(this.backupDBToolStripMenuItem_Click);
            // 
            // showDBToolStripMenuItem
            // 
            this.showDBToolStripMenuItem.Name = "showDBToolStripMenuItem";
            this.showDBToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.showDBToolStripMenuItem.Text = "Отображение БД";
            this.showDBToolStripMenuItem.Visible = false;
            this.showDBToolStripMenuItem.Click += new System.EventHandler(this.showDBToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 34);
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
            this.pictureBox2.Location = new System.Drawing.Point(331, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 174);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // LabelAllowance
            // 
            this.LabelAllowance.AutoSize = true;
            this.LabelAllowance.Location = new System.Drawing.Point(6, 204);
            this.LabelAllowance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAllowance.Name = "LabelAllowance";
            this.LabelAllowance.Size = new System.Drawing.Size(133, 13);
            this.LabelAllowance.TabIndex = 56;
            this.LabelAllowance.Text = "Допуск, мкм (без знака)";
            this.LabelAllowance.Visible = false;
            // 
            // Allowance
            // 
            this.Allowance.Location = new System.Drawing.Point(143, 199);
            this.Allowance.Margin = new System.Windows.Forms.Padding(2);
            this.Allowance.Name = "Allowance";
            this.Allowance.Size = new System.Drawing.Size(76, 20);
            this.Allowance.TabIndex = 57;
            this.Allowance.Visible = false;
            this.Allowance.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Allowance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // TreeOfSelectedOperations
            // 
            this.TreeOfSelectedOperations.BackColor = System.Drawing.SystemColors.Window;
            this.TreeOfSelectedOperations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeOfSelectedOperations.Enabled = false;
            this.TreeOfSelectedOperations.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TreeOfSelectedOperations.Location = new System.Drawing.Point(371, 163);
            this.TreeOfSelectedOperations.Name = "TreeOfSelectedOperations";
            this.TreeOfSelectedOperations.Size = new System.Drawing.Size(298, 149);
            this.TreeOfSelectedOperations.TabIndex = 58;
            this.TreeOfSelectedOperations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeOfSelectedOperations_AfterSelect);
            this.TreeOfSelectedOperations.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeOfSelectedOperations_NodeMouseClick);
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(362, 93);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(77, 37);
            this.SaveChanges.TabIndex = 59;
            this.SaveChanges.Text = "Сохранить изменения";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Visible = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // addSurfaceButton
            // 
            this.addSurfaceButton.Enabled = false;
            this.addSurfaceButton.Location = new System.Drawing.Point(281, 296);
            this.addSurfaceButton.Name = "addSurfaceButton";
            this.addSurfaceButton.Size = new System.Drawing.Size(132, 33);
            this.addSurfaceButton.TabIndex = 61;
            this.addSurfaceButton.Text = "Добавить поверхность";
            this.addSurfaceButton.UseVisualStyleBackColor = true;
            this.addSurfaceButton.Visible = false;
            this.addSurfaceButton.Click += new System.EventHandler(this.addSurfaceButton_Click);
            // 
            // delSurfaceButton
            // 
            this.delSurfaceButton.Enabled = false;
            this.delSurfaceButton.Location = new System.Drawing.Point(281, 331);
            this.delSurfaceButton.Name = "delSurfaceButton";
            this.delSurfaceButton.Size = new System.Drawing.Size(132, 33);
            this.delSurfaceButton.TabIndex = 62;
            this.delSurfaceButton.Text = "Удалить поверхность";
            this.delSurfaceButton.UseVisualStyleBackColor = true;
            this.delSurfaceButton.Visible = false;
            this.delSurfaceButton.Click += new System.EventHandler(this.delSurfaceButton_Click);
            // 
            // SurfacesTreeView
            // 
            this.SurfacesTreeView.Enabled = false;
            this.SurfacesTreeView.Location = new System.Drawing.Point(13, 296);
            this.SurfacesTreeView.Name = "SurfacesTreeView";
            this.SurfacesTreeView.Size = new System.Drawing.Size(262, 68);
            this.SurfacesTreeView.TabIndex = 60;
            this.SurfacesTreeView.Visible = false;
            this.SurfacesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeOfSelectedOperations_AfterSelect);
            this.SurfacesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SurfacesTreeView_NodeMouseClick);
            // 
            // Surfaces
            // 
            this.Surfaces.AutoSize = true;
            this.Surfaces.Location = new System.Drawing.Point(6, 269);
            this.Surfaces.Name = "Surfaces";
            this.Surfaces.Size = new System.Drawing.Size(127, 13);
            this.Surfaces.TabIndex = 64;
            this.Surfaces.Text = "Название поверхности:";
            this.Surfaces.Visible = false;
            // 
            // SelectTechnologicalProcess
            // 
            this.SelectTechnologicalProcess.Enabled = false;
            this.SelectTechnologicalProcess.Location = new System.Drawing.Point(379, 318);
            this.SelectTechnologicalProcess.Name = "SelectTechnologicalProcess";
            this.SelectTechnologicalProcess.Size = new System.Drawing.Size(290, 35);
            this.SelectTechnologicalProcess.TabIndex = 67;
            this.SelectTechnologicalProcess.Text = "Выбор технологического процесса";
            this.SelectTechnologicalProcess.UseVisualStyleBackColor = true;
            this.SelectTechnologicalProcess.Click += new System.EventHandler(this.SelectTechnologicalProcess_Click);
            // 
            // SurfaceRoughness
            // 
            this.SurfaceRoughness.Location = new System.Drawing.Point(143, 224);
            this.SurfaceRoughness.Name = "SurfaceRoughness";
            this.SurfaceRoughness.Size = new System.Drawing.Size(85, 20);
            this.SurfaceRoughness.TabIndex = 68;
            this.SurfaceRoughness.Text = "0,01";
            this.SurfaceRoughness.Visible = false;
            this.SurfaceRoughness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // NameSurface
            // 
            this.NameSurface.Location = new System.Drawing.Point(138, 266);
            this.NameSurface.Margin = new System.Windows.Forms.Padding(2);
            this.NameSurface.Name = "NameSurface";
            this.NameSurface.Size = new System.Drawing.Size(275, 20);
            this.NameSurface.TabIndex = 69;
            this.NameSurface.Visible = false;
            this.NameSurface.TextChanged += new System.EventHandler(this.NameSurface_TextChanged);
            // 
            // LabelRoughness
            // 
            this.LabelRoughness.AutoSize = true;
            this.LabelRoughness.Location = new System.Drawing.Point(6, 227);
            this.LabelRoughness.Name = "LabelRoughness";
            this.LabelRoughness.Size = new System.Drawing.Size(133, 13);
            this.LabelRoughness.TabIndex = 70;
            this.LabelRoughness.Text = "Шероховатость (Ra,мкм)";
            this.LabelRoughness.Visible = false;
            // 
            // labelOperationsOrTechProcess
            // 
            this.labelOperationsOrTechProcess.AutoSize = true;
            this.labelOperationsOrTechProcess.Enabled = false;
            this.labelOperationsOrTechProcess.Location = new System.Drawing.Point(142, 144);
            this.labelOperationsOrTechProcess.Name = "labelOperationsOrTechProcess";
            this.labelOperationsOrTechProcess.Size = new System.Drawing.Size(91, 13);
            this.labelOperationsOrTechProcess.TabIndex = 71;
            this.labelOperationsOrTechProcess.Text = "Выбор операций";
            // 
            // labelOfSelectedOperations
            // 
            this.labelOfSelectedOperations.AutoSize = true;
            this.labelOfSelectedOperations.Enabled = false;
            this.labelOfSelectedOperations.Location = new System.Drawing.Point(455, 144);
            this.labelOfSelectedOperations.Name = "labelOfSelectedOperations";
            this.labelOfSelectedOperations.Size = new System.Drawing.Size(157, 13);
            this.labelOfSelectedOperations.TabIndex = 72;
            this.labelOfSelectedOperations.Text = "Дерево выбранных операций";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 364);
            this.Controls.Add(this.labelOfSelectedOperations);
            this.Controls.Add(this.labelOperationsOrTechProcess);
            this.Controls.Add(this.LabelRoughness);
            this.Controls.Add(this.NameSurface);
            this.Controls.Add(this.SurfaceRoughness);
            this.Controls.Add(this.SelectTechnologicalProcess);
            this.Controls.Add(this.Surfaces);
            this.Controls.Add(this.delSurfaceButton);
            this.Controls.Add(this.addSurfaceButton);
            this.Controls.Add(this.SurfacesTreeView);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.TreeOfSelectedOperations);
            this.Controls.Add(this.Allowance);
            this.Controls.Add(this.LabelAllowance);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTypeOfInstrument);
            this.Controls.Add(this.LabelTypeOfMachining);
            this.Controls.Add(this.HoleDepth);
            this.Controls.Add(this.LabelHoleDepth);
            this.Controls.Add(this.CalculationOfSchema);
            this.Controls.Add(this.TypeOfInstrument);
            this.Controls.Add(this.LengthOfPart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.LabelWorkpiece);
            this.Controls.Add(this.NameOfWorkpiece);
            this.Controls.Add(this.TypeOfMachining);
            this.Controls.Add(this.ChoiceOfWorkpiece);
            this.Controls.Add(this.ChoiceOfOperation);
            this.Controls.Add(this.TreeOfOperations);
            this.Controls.Add(this.TypeOfAllowance);
            this.Controls.Add(this.LabelTypeOfAllowance);
            this.Controls.Add(this.TypeOfProcessedSurface);
            this.Controls.Add(this.LabelTypeOfProcessedSurface);
            this.Controls.Add(this.LabelTypeOfPart);
            this.Controls.Add(this.TypeOfPart);
            this.Controls.Add(this.DiameterOfPart);
            this.Controls.Add(this.LabelDiameterOfPart);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1100, 597);
            this.MinimumSize = new System.Drawing.Size(200, 98);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Расчёт технологической размерной цепи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьБДToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        protected internal System.Windows.Forms.Button CalculationOfSchema;
        protected internal System.Windows.Forms.Button ChoiceOfWorkpiece;
        protected internal System.Windows.Forms.TextBox HoleDepth;
        protected internal System.Windows.Forms.TextBox DiameterOfPart;
        protected internal System.Windows.Forms.ComboBox TypeOfAllowance;
        protected internal System.Windows.Forms.TextBox LengthOfPart;
        protected internal System.Windows.Forms.ComboBox TypeOfPart;
        protected internal System.Windows.Forms.ComboBox TypeOfProcessedSurface;
        protected internal System.Windows.Forms.TextBox TypeOfMachining;
        protected internal System.Windows.Forms.TextBox Allowance;
        protected internal System.Windows.Forms.ComboBox TypeOfInstrument;
        protected internal System.Windows.Forms.TextBox NameOfWorkpiece;
        protected internal System.Windows.Forms.TreeView TreeOfOperations;
        protected internal System.Windows.Forms.Button ChoiceOfOperation;
        protected internal System.Windows.Forms.Button Backspace;
        protected internal System.Windows.Forms.TreeView TreeOfSelectedOperations;
        protected internal System.Windows.Forms.Button SaveChanges;
        protected internal System.Windows.Forms.Button addSurfaceButton;
        protected internal System.Windows.Forms.Button delSurfaceButton;
        protected internal System.Windows.Forms.TreeView SurfacesTreeView;
        protected internal System.Windows.Forms.TextBox SurfaceRoughness;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выборПодключенияToolStripMenuItem;
        protected internal System.Windows.Forms.TextBox NameSurface;
        protected internal System.Windows.Forms.Label labelOperationsOrTechProcess;
        protected internal System.Windows.Forms.Label Surfaces;
        protected internal System.Windows.Forms.Label labelOfSelectedOperations;
        protected internal System.Windows.Forms.Button SelectTechnologicalProcess;
        private System.Windows.Forms.ToolStripMenuItem showDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDBToolStripMenuItem;
        protected internal System.Windows.Forms.Label LabelDiameterOfPart;
        protected internal System.Windows.Forms.Label LabelTypeOfPart;
        protected internal System.Windows.Forms.Label LabelTypeOfProcessedSurface;
        protected internal System.Windows.Forms.Label LabelTypeOfAllowance;
        protected internal System.Windows.Forms.Label LabelHoleDepth;
        protected internal System.Windows.Forms.Label LabelAllowance;
        protected internal System.Windows.Forms.Label LabelRoughness;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.PictureBox pictureBox2;
        protected internal System.Windows.Forms.Label LabelWorkpiece;
        protected internal System.Windows.Forms.Label LabelTypeOfMachining;
        protected internal System.Windows.Forms.Label LabelTypeOfInstrument;
    }
}

