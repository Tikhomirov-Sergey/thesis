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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemBackup = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Part = new System.Windows.Forms.ComboBox();
            this.Calculation = new System.Windows.Forms.ComboBox();
            this.TechnologicalProcess = new System.Windows.Forms.DataGridView();
            this.Surfaces = new System.Windows.Forms.ComboBox();
            this.Operations = new System.Windows.Forms.DataGridView();
            this.LengthPart = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechnologicalProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Operations)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор записи \r\n       из БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по дате:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(925, 46);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удаление записи \r\n        из БД";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(675, 54);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(535, 57);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(106, 51);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по\r\nнаименованию\r\nдетали:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBackup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1827, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemBackup
            // 
            this.ToolStripMenuItemBackup.Name = "ToolStripMenuItemBackup";
            this.ToolStripMenuItemBackup.Size = new System.Drawing.Size(216, 24);
            this.ToolStripMenuItemBackup.Text = "Резервное копирование БД";
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
            // Part
            // 
            this.Part.FormattingEnabled = true;
            this.Part.Location = new System.Drawing.Point(104, 114);
            this.Part.Margin = new System.Windows.Forms.Padding(4);
            this.Part.Name = "Part";
            this.Part.Size = new System.Drawing.Size(160, 24);
            this.Part.TabIndex = 13;
            this.Part.TextChanged += new System.EventHandler(this.Part_TextChanged);
            // 
            // Calculation
            // 
            this.Calculation.FormattingEnabled = true;
            this.Calculation.Location = new System.Drawing.Point(315, 114);
            this.Calculation.Margin = new System.Windows.Forms.Padding(4);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(160, 24);
            this.Calculation.TabIndex = 14;
            this.Calculation.TextChanged += new System.EventHandler(this.Calculation_TextChanged);
            // 
            // TechnologicalProcess
            // 
            this.TechnologicalProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TechnologicalProcess.Location = new System.Drawing.Point(77, 146);
            this.TechnologicalProcess.Margin = new System.Windows.Forms.Padding(4);
            this.TechnologicalProcess.Name = "TechnologicalProcess";
            this.TechnologicalProcess.Size = new System.Drawing.Size(946, 331);
            this.TechnologicalProcess.TabIndex = 15;
            // 
            // Surfaces
            // 
            this.Surfaces.FormattingEnabled = true;
            this.Surfaces.Location = new System.Drawing.Point(632, 114);
            this.Surfaces.Margin = new System.Windows.Forms.Padding(4);
            this.Surfaces.Name = "Surfaces";
            this.Surfaces.Size = new System.Drawing.Size(335, 24);
            this.Surfaces.TabIndex = 16;
            // 
            // Operations
            // 
            this.Operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Operations.Location = new System.Drawing.Point(77, 503);
            this.Operations.Margin = new System.Windows.Forms.Padding(4);
            this.Operations.Name = "Operations";
            this.Operations.Size = new System.Drawing.Size(946, 320);
            this.Operations.TabIndex = 17;
            // 
            // LengthPart
            // 
            this.LengthPart.Location = new System.Drawing.Point(170, 87);
            this.LengthPart.Name = "LengthPart";
            this.LengthPart.Size = new System.Drawing.Size(100, 22);
            this.LengthPart.TabIndex = 18;
            // 
            // FormOfWorkWithDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 921);
            this.Controls.Add(this.LengthPart);
            this.Controls.Add(this.Operations);
            this.Controls.Add(this.Surfaces);
            this.Controls.Add(this.TechnologicalProcess);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.Part);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOfWorkWithDatabase";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechnologicalProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Operations)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinadetaliLмDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBackup;
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
        protected internal System.Windows.Forms.ComboBox Part;
        protected internal System.Windows.Forms.ComboBox Calculation;
        protected internal System.Windows.Forms.DataGridView TechnologicalProcess;
        protected internal System.Windows.Forms.ComboBox Surfaces;
        protected internal System.Windows.Forms.DataGridView Operations;
        protected internal System.Windows.Forms.TextBox LengthPart;
    }
}