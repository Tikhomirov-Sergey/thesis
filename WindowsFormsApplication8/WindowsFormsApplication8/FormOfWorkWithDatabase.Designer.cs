namespace WindowsFormsApplication8
{
    partial class FormOfWorkWithDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SearchByCipher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chainsDataSet1 = new WindowsFormsApplication8.ChainsDataSet1();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.DetailTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.TableAdapterManager();
            this.calculationTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.CalculationTableAdapter();
            this.operationsTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.OperationsTableAdapter();
            this.surfaceTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.SurfaceTableAdapter();
            this.calculationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NamePart = new System.Windows.Forms.ComboBox();
            this.Calculation = new System.Windows.Forms.ComboBox();
            this.Surfaces = new System.Windows.Forms.ComboBox();
            this.LengthPart = new System.Windows.Forms.TextBox();
            this.TechnologicalProcess = new System.Windows.Forms.TreeView();
            this.diameterOfSurface = new System.Windows.Forms.TextBox();
            this.typeOfPart = new System.Windows.Forms.TextBox();
            this.typeOfAllowance = new System.Windows.Forms.TextBox();
            this.TypeOfProcessedSurface = new System.Windows.Forms.TextBox();
            this.SurfaceRoughness = new System.Windows.Forms.TextBox();
            this.HoleDepth = new System.Windows.Forms.TextBox();
            this.Tolerance = new System.Windows.Forms.TextBox();
            this.Operations = new System.Windows.Forms.TreeView();
            this.labelCipherPart = new System.Windows.Forms.Label();
            this.LabelOperaions = new System.Windows.Forms.Label();
            this.LabelTechnologicalProcess = new System.Windows.Forms.Label();
            this.LabelTypeOfPart = new System.Windows.Forms.Label();
            this.LabelTypeOfAllowance = new System.Windows.Forms.Label();
            this.LabelTypeOfProcessedSurface = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LabelDiameterOfPart = new System.Windows.Forms.Label();
            this.labelPart = new System.Windows.Forms.Label();
            this.CipherPart = new System.Windows.Forms.ComboBox();
            this.LabelHoleDepth = new System.Windows.Forms.Label();
            this.LabelAllowance = new System.Windows.Forms.Label();
            this.LabelRoughness = new System.Windows.Forms.Label();
            this.labelSurfaces = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор записи \r\n       из БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по дате:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SearchByName
            // 
            this.SearchByName.Location = new System.Drawing.Point(812, 26);
            this.SearchByName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(163, 22);
            this.SearchByName.TabIndex = 5;
            this.SearchByName.TextChanged += new System.EventHandler(this.SearchByName_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(979, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(821, 263);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удаление записи \r\n        из БД";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(979, 54);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // SearchByCipher
            // 
            this.SearchByCipher.Location = new System.Drawing.Point(812, 54);
            this.SearchByCipher.Margin = new System.Windows.Forms.Padding(4);
            this.SearchByCipher.Name = "SearchByCipher";
            this.SearchByCipher.Size = new System.Drawing.Size(163, 22);
            this.SearchByCipher.TabIndex = 9;
            this.SearchByCipher.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(572, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по наименованию детали:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chainsDataSet1
            // 
            this.chainsDataSet1.DataSetName = "ChainsDataSet1";
            this.chainsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailBindingSource
            // 
            this.detailBindingSource.DataMember = "Detail";
            this.detailBindingSource.DataSource = this.chainsDataSet1;
            // 
            // detailTableAdapter
            // 
            this.detailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculationTableAdapter = this.calculationTableAdapter;
            this.tableAdapterManager.ChamferTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = this.detailTableAdapter;
            this.tableAdapterManager.Operations_and_ResultsTableAdapter = null;
            this.tableAdapterManager.OperationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.SurfaceTableAdapter = this.surfaceTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication8.ChainsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calculationTableAdapter
            // 
            this.calculationTableAdapter.ClearBeforeFill = true;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // surfaceTableAdapter
            // 
            this.surfaceTableAdapter.ClearBeforeFill = true;
            // 
            // calculationBindingSource
            // 
            this.calculationBindingSource.DataMember = "Calculation";
            this.calculationBindingSource.DataSource = this.chainsDataSet1;
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this.chainsDataSet1;
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataMember = "Surface";
            this.surfaceBindingSource.DataSource = this.chainsDataSet1;
            // 
            // NamePart
            // 
            this.NamePart.FormattingEnabled = true;
            this.NamePart.Location = new System.Drawing.Point(783, 116);
            this.NamePart.Margin = new System.Windows.Forms.Padding(4);
            this.NamePart.Name = "NamePart";
            this.NamePart.Size = new System.Drawing.Size(160, 24);
            this.NamePart.TabIndex = 13;
            this.NamePart.SelectedIndexChanged += new System.EventHandler(this.NamePart_SelectedIndexChanged);
            // 
            // Calculation
            // 
            this.Calculation.FormattingEnabled = true;
            this.Calculation.Location = new System.Drawing.Point(783, 180);
            this.Calculation.Margin = new System.Windows.Forms.Padding(4);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(160, 24);
            this.Calculation.TabIndex = 14;
            this.Calculation.SelectedIndexChanged += new System.EventHandler(this.Calculation_SelectedIndexChanged);
            // 
            // Surfaces
            // 
            this.Surfaces.FormattingEnabled = true;
            this.Surfaces.Location = new System.Drawing.Point(783, 212);
            this.Surfaces.Margin = new System.Windows.Forms.Padding(4);
            this.Surfaces.Name = "Surfaces";
            this.Surfaces.Size = new System.Drawing.Size(160, 24);
            this.Surfaces.TabIndex = 16;
            this.Surfaces.SelectedIndexChanged += new System.EventHandler(this.Surfaces_SelectedIndexChanged);
            // 
            // LengthPart
            // 
            this.LengthPart.Location = new System.Drawing.Point(161, 27);
            this.LengthPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthPart.Name = "LengthPart";
            this.LengthPart.Size = new System.Drawing.Size(100, 22);
            this.LengthPart.TabIndex = 18;
            // 
            // TechnologicalProcess
            // 
            this.TechnologicalProcess.Location = new System.Drawing.Point(7, 340);
            this.TechnologicalProcess.Margin = new System.Windows.Forms.Padding(4);
            this.TechnologicalProcess.Name = "TechnologicalProcess";
            this.TechnologicalProcess.Size = new System.Drawing.Size(532, 245);
            this.TechnologicalProcess.TabIndex = 19;
            // 
            // diameterOfSurface
            // 
            this.diameterOfSurface.Location = new System.Drawing.Point(333, 50);
            this.diameterOfSurface.Margin = new System.Windows.Forms.Padding(4);
            this.diameterOfSurface.Name = "diameterOfSurface";
            this.diameterOfSurface.Size = new System.Drawing.Size(132, 22);
            this.diameterOfSurface.TabIndex = 20;
            // 
            // typeOfPart
            // 
            this.typeOfPart.Location = new System.Drawing.Point(122, 79);
            this.typeOfPart.Margin = new System.Windows.Forms.Padding(4);
            this.typeOfPart.Name = "typeOfPart";
            this.typeOfPart.Size = new System.Drawing.Size(91, 22);
            this.typeOfPart.TabIndex = 21;
            // 
            // typeOfAllowance
            // 
            this.typeOfAllowance.Location = new System.Drawing.Point(122, 106);
            this.typeOfAllowance.Margin = new System.Windows.Forms.Padding(4);
            this.typeOfAllowance.Name = "typeOfAllowance";
            this.typeOfAllowance.Size = new System.Drawing.Size(91, 22);
            this.typeOfAllowance.TabIndex = 22;
            // 
            // TypeOfProcessedSurface
            // 
            this.TypeOfProcessedSurface.Location = new System.Drawing.Point(273, 136);
            this.TypeOfProcessedSurface.Margin = new System.Windows.Forms.Padding(4);
            this.TypeOfProcessedSurface.Name = "TypeOfProcessedSurface";
            this.TypeOfProcessedSurface.Size = new System.Drawing.Size(132, 22);
            this.TypeOfProcessedSurface.TabIndex = 23;
            // 
            // SurfaceRoughness
            // 
            this.SurfaceRoughness.Location = new System.Drawing.Point(188, 219);
            this.SurfaceRoughness.Margin = new System.Windows.Forms.Padding(4);
            this.SurfaceRoughness.Name = "SurfaceRoughness";
            this.SurfaceRoughness.Size = new System.Drawing.Size(95, 22);
            this.SurfaceRoughness.TabIndex = 24;
            // 
            // HoleDepth
            // 
            this.HoleDepth.Location = new System.Drawing.Point(210, 163);
            this.HoleDepth.Margin = new System.Windows.Forms.Padding(4);
            this.HoleDepth.Name = "HoleDepth";
            this.HoleDepth.Size = new System.Drawing.Size(72, 22);
            this.HoleDepth.TabIndex = 25;
            this.HoleDepth.TextChanged += new System.EventHandler(this.HoleDepth_TextChanged);
            // 
            // Tolerance
            // 
            this.Tolerance.Location = new System.Drawing.Point(198, 191);
            this.Tolerance.Margin = new System.Windows.Forms.Padding(4);
            this.Tolerance.Name = "Tolerance";
            this.Tolerance.Size = new System.Drawing.Size(84, 22);
            this.Tolerance.TabIndex = 26;
            // 
            // Operations
            // 
            this.Operations.Location = new System.Drawing.Point(555, 340);
            this.Operations.Margin = new System.Windows.Forms.Padding(4);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(532, 245);
            this.Operations.TabIndex = 27;
            // 
            // labelCipherPart
            // 
            this.labelCipherPart.AutoSize = true;
            this.labelCipherPart.Location = new System.Drawing.Point(676, 151);
            this.labelCipherPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCipherPart.Name = "labelCipherPart";
            this.labelCipherPart.Size = new System.Drawing.Size(97, 17);
            this.labelCipherPart.TabIndex = 28;
            this.labelCipherPart.Text = "Шифр детали";
            // 
            // LabelOperaions
            // 
            this.LabelOperaions.AutoSize = true;
            this.LabelOperaions.Location = new System.Drawing.Point(796, 320);
            this.LabelOperaions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOperaions.Name = "LabelOperaions";
            this.LabelOperaions.Size = new System.Drawing.Size(75, 17);
            this.LabelOperaions.TabIndex = 29;
            this.LabelOperaions.Text = "Операции";
            // 
            // LabelTechnologicalProcess
            // 
            this.LabelTechnologicalProcess.AutoSize = true;
            this.LabelTechnologicalProcess.Location = new System.Drawing.Point(187, 320);
            this.LabelTechnologicalProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTechnologicalProcess.Name = "LabelTechnologicalProcess";
            this.LabelTechnologicalProcess.Size = new System.Drawing.Size(180, 17);
            this.LabelTechnologicalProcess.TabIndex = 30;
            this.LabelTechnologicalProcess.Text = "Технологический процесс";
            // 
            // LabelTypeOfPart
            // 
            this.LabelTypeOfPart.AutoSize = true;
            this.LabelTypeOfPart.Location = new System.Drawing.Point(13, 81);
            this.LabelTypeOfPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTypeOfPart.Name = "LabelTypeOfPart";
            this.LabelTypeOfPart.Size = new System.Drawing.Size(97, 17);
            this.LabelTypeOfPart.TabIndex = 31;
            this.LabelTypeOfPart.Text = "Тип размера:";
            // 
            // LabelTypeOfAllowance
            // 
            this.LabelTypeOfAllowance.AutoSize = true;
            this.LabelTypeOfAllowance.Location = new System.Drawing.Point(13, 109);
            this.LabelTypeOfAllowance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTypeOfAllowance.Name = "LabelTypeOfAllowance";
            this.LabelTypeOfAllowance.Size = new System.Drawing.Size(102, 17);
            this.LabelTypeOfAllowance.TabIndex = 32;
            this.LabelTypeOfAllowance.Text = "Тип припуска:";
            // 
            // LabelTypeOfProcessedSurface
            // 
            this.LabelTypeOfProcessedSurface.AutoSize = true;
            this.LabelTypeOfProcessedSurface.Location = new System.Drawing.Point(13, 140);
            this.LabelTypeOfProcessedSurface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTypeOfProcessedSurface.Name = "LabelTypeOfProcessedSurface";
            this.LabelTypeOfProcessedSurface.Size = new System.Drawing.Size(245, 17);
            this.LabelTypeOfProcessedSurface.TabIndex = 33;
            this.LabelTypeOfProcessedSurface.Text = "Тип обрабатываемой  поверхности:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 17);
            this.label15.TabIndex = 37;
            this.label15.Text = "Длина детали (l,мм):";
            // 
            // LabelDiameterOfPart
            // 
            this.LabelDiameterOfPart.AutoSize = true;
            this.LabelDiameterOfPart.Location = new System.Drawing.Point(13, 54);
            this.LabelDiameterOfPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDiameterOfPart.Name = "LabelDiameterOfPart";
            this.LabelDiameterOfPart.Size = new System.Drawing.Size(301, 17);
            this.LabelDiameterOfPart.TabIndex = 38;
            this.LabelDiameterOfPart.Text = "Обрабатываемый размер/Диаметр (L/d,мм):";
            // 
            // labelPart
            // 
            this.labelPart.AutoSize = true;
            this.labelPart.Location = new System.Drawing.Point(715, 119);
            this.labelPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPart.Name = "labelPart";
            this.labelPart.Size = new System.Drawing.Size(57, 17);
            this.labelPart.TabIndex = 39;
            this.labelPart.Text = "Деталь";
            // 
            // CipherPart
            // 
            this.CipherPart.FormattingEnabled = true;
            this.CipherPart.Location = new System.Drawing.Point(783, 148);
            this.CipherPart.Margin = new System.Windows.Forms.Padding(4);
            this.CipherPart.Name = "CipherPart";
            this.CipherPart.Size = new System.Drawing.Size(160, 24);
            this.CipherPart.TabIndex = 40;
            this.CipherPart.SelectedIndexChanged += new System.EventHandler(this.CipherPart_SelectedIndexChanged);
            // 
            // LabelHoleDepth
            // 
            this.LabelHoleDepth.AutoSize = true;
            this.LabelHoleDepth.Location = new System.Drawing.Point(13, 167);
            this.LabelHoleDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHoleDepth.Name = "LabelHoleDepth";
            this.LabelHoleDepth.Size = new System.Drawing.Size(186, 17);
            this.LabelHoleDepth.TabIndex = 44;
            this.LabelHoleDepth.Text = "Глубина отверстия (lo,мм):";
            // 
            // LabelAllowance
            // 
            this.LabelAllowance.AutoSize = true;
            this.LabelAllowance.Location = new System.Drawing.Point(13, 194);
            this.LabelAllowance.Name = "LabelAllowance";
            this.LabelAllowance.Size = new System.Drawing.Size(168, 17);
            this.LabelAllowance.TabIndex = 57;
            this.LabelAllowance.Text = "Допуск, мкм (без знака)";
            // 
            // LabelRoughness
            // 
            this.LabelRoughness.AutoSize = true;
            this.LabelRoughness.Location = new System.Drawing.Point(13, 223);
            this.LabelRoughness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelRoughness.Name = "LabelRoughness";
            this.LabelRoughness.Size = new System.Drawing.Size(159, 17);
            this.LabelRoughness.TabIndex = 71;
            this.LabelRoughness.Text = "Шероховатость Ra,мкм";
            // 
            // labelSurfaces
            // 
            this.labelSurfaces.AutoSize = true;
            this.labelSurfaces.Location = new System.Drawing.Point(681, 216);
            this.labelSurfaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurfaces.Name = "labelSurfaces";
            this.labelSurfaces.Size = new System.Drawing.Size(92, 17);
            this.labelSurfaces.TabIndex = 72;
            this.labelSurfaces.Text = "Поверхность";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(731, 184);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(42, 17);
            this.labelDate.TabIndex = 73;
            this.labelDate.Text = "Дата";
            // 
            // FormOfWorkWithDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 592);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSurfaces);
            this.Controls.Add(this.LabelRoughness);
            this.Controls.Add(this.LabelAllowance);
            this.Controls.Add(this.LabelHoleDepth);
            this.Controls.Add(this.CipherPart);
            this.Controls.Add(this.labelPart);
            this.Controls.Add(this.LabelDiameterOfPart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LabelTypeOfProcessedSurface);
            this.Controls.Add(this.LabelTypeOfAllowance);
            this.Controls.Add(this.LabelTypeOfPart);
            this.Controls.Add(this.LabelTechnologicalProcess);
            this.Controls.Add(this.LabelOperaions);
            this.Controls.Add(this.labelCipherPart);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.Tolerance);
            this.Controls.Add(this.HoleDepth);
            this.Controls.Add(this.SurfaceRoughness);
            this.Controls.Add(this.TypeOfProcessedSurface);
            this.Controls.Add(this.typeOfAllowance);
            this.Controls.Add(this.typeOfPart);
            this.Controls.Add(this.diameterOfSurface);
            this.Controls.Add(this.TechnologicalProcess);
            this.Controls.Add(this.LengthPart);
            this.Controls.Add(this.Surfaces);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.NamePart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchByCipher);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOfWorkWithDatabase";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr12DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr14DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinadetaliLмDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private ChainsDataSet1 chainsDataSet1;
        private System.Windows.Forms.BindingSource detailBindingSource;
        private ChainsDataSet1TableAdapters.DetailTableAdapter detailTableAdapter;
        private ChainsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private ChainsDataSet1TableAdapters.CalculationTableAdapter calculationTableAdapter;
        private System.Windows.Forms.BindingSource calculationBindingSource;
        private ChainsDataSet1TableAdapters.OperationsTableAdapter operationsTableAdapter;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private ChainsDataSet1TableAdapters.SurfaceTableAdapter surfaceTableAdapter;
        private System.Windows.Forms.BindingSource surfaceBindingSource;
        protected internal System.Windows.Forms.ComboBox NamePart;
        protected internal System.Windows.Forms.ComboBox Calculation;
        protected internal System.Windows.Forms.ComboBox Surfaces;
        protected internal System.Windows.Forms.TextBox LengthPart;
        protected internal System.Windows.Forms.TreeView TechnologicalProcess;
        protected internal System.Windows.Forms.TextBox diameterOfSurface;
        protected internal System.Windows.Forms.TextBox typeOfPart;
        protected internal System.Windows.Forms.TextBox typeOfAllowance;
        protected internal System.Windows.Forms.TextBox TypeOfProcessedSurface;
        protected internal System.Windows.Forms.TextBox SurfaceRoughness;
        protected internal System.Windows.Forms.TextBox HoleDepth;
        protected internal System.Windows.Forms.TextBox Tolerance;
        protected internal System.Windows.Forms.TreeView Operations;
        private System.Windows.Forms.Label labelCipherPart;
        private System.Windows.Forms.Label LabelOperaions;
        private System.Windows.Forms.Label LabelTechnologicalProcess;
        protected internal System.Windows.Forms.Label LabelTypeOfPart;
        protected internal System.Windows.Forms.Label LabelTypeOfAllowance;
        protected internal System.Windows.Forms.Label LabelTypeOfProcessedSurface;
        private System.Windows.Forms.Label label15;
        protected internal System.Windows.Forms.Label LabelDiameterOfPart;
        private System.Windows.Forms.Label labelPart;
        protected internal System.Windows.Forms.ComboBox CipherPart;
        protected internal System.Windows.Forms.Label LabelHoleDepth;
        protected internal System.Windows.Forms.Label LabelAllowance;
        protected internal System.Windows.Forms.Label LabelRoughness;
        private System.Windows.Forms.Label labelSurfaces;
        private System.Windows.Forms.Label labelDate;
        protected internal System.Windows.Forms.TextBox SearchByName;
        protected internal System.Windows.Forms.TextBox SearchByCipher;
    }
}