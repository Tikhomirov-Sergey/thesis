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
            this.detailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculationTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.CalculationTableAdapter();
            this.calculationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.OperationsTableAdapter();
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.SurfaceTableAdapter();
            this.surfaceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
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
            this.button3.Size = new System.Drawing.Size(144, 51);
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
            // detailDataGridView
            // 
            this.detailDataGridView.AutoGenerateColumns = false;
            this.detailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.detailDataGridView.DataSource = this.detailBindingSource;
            this.detailDataGridView.Location = new System.Drawing.Point(12, 100);
            this.detailDataGridView.Name = "detailDataGridView";
            this.detailDataGridView.RowTemplate.Height = 24;
            this.detailDataGridView.Size = new System.Drawing.Size(470, 188);
            this.detailDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn22.HeaderText = "Name";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "cipher_detail";
            this.dataGridViewTextBoxColumn23.HeaderText = "cipher_detail";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn24.HeaderText = "Date";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "length_detail";
            this.dataGridViewTextBoxColumn25.HeaderText = "length_detail";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // calculationBindingSource
            // 
            this.calculationBindingSource.DataMember = "Calculation";
            this.calculationBindingSource.DataSource = this.chainsDataSet1;
            // 
            // calculationTableAdapter
            // 
            this.calculationTableAdapter.ClearBeforeFill = true;
            // 
            // calculationDataGridView
            // 
            this.calculationDataGridView.AutoGenerateColumns = false;
            this.calculationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calculationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.calculationDataGridView.DataSource = this.calculationBindingSource;
            this.calculationDataGridView.Location = new System.Drawing.Point(505, 100);
            this.calculationDataGridView.Name = "calculationDataGridView";
            this.calculationDataGridView.RowTemplate.Height = 24;
            this.calculationDataGridView.Size = new System.Drawing.Size(412, 188);
            this.calculationDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn26.HeaderText = "ID";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Cipher_detail";
            this.dataGridViewTextBoxColumn27.HeaderText = "Cipher_detail";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn28.HeaderText = "Date";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this.chainsDataSet1;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // operationsDataGridView
            // 
            this.operationsDataGridView.AutoGenerateColumns = false;
            this.operationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34});
            this.operationsDataGridView.DataSource = this.operationsBindingSource;
            this.operationsDataGridView.Location = new System.Drawing.Point(12, 294);
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.RowTemplate.Height = 24;
            this.operationsDataGridView.Size = new System.Drawing.Size(470, 220);
            this.operationsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "№_operation";
            this.dataGridViewTextBoxColumn29.HeaderText = "№_operation";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Code_operation";
            this.dataGridViewTextBoxColumn30.HeaderText = "Code_operation";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn31.HeaderText = "Name";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "cipher_detail";
            this.dataGridViewTextBoxColumn32.HeaderText = "cipher_detail";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "ID_\r\ncalculation";
            this.dataGridViewTextBoxColumn33.HeaderText = "ID_\r\ncalculation";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn34.HeaderText = "ID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataMember = "Surface";
            this.surfaceBindingSource.DataSource = this.chainsDataSet1;
            // 
            // surfaceTableAdapter
            // 
            this.surfaceTableAdapter.ClearBeforeFill = true;
            // 
            // surfaceDataGridView
            // 
            this.surfaceDataGridView.AutoGenerateColumns = false;
            this.surfaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.surfaceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42});
            this.surfaceDataGridView.DataSource = this.surfaceBindingSource;
            this.surfaceDataGridView.Location = new System.Drawing.Point(505, 294);
            this.surfaceDataGridView.Name = "surfaceDataGridView";
            this.surfaceDataGridView.RowTemplate.Height = 24;
            this.surfaceDataGridView.Size = new System.Drawing.Size(412, 220);
            this.surfaceDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Surface_cipher";
            this.dataGridViewTextBoxColumn35.HeaderText = "Surface_cipher";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Cipher_detail";
            this.dataGridViewTextBoxColumn36.HeaderText = "Cipher_detail";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "View";
            this.dataGridViewTextBoxColumn37.HeaderText = "View";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Diameter";
            this.dataGridViewTextBoxColumn38.HeaderText = "Diameter";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Size_type";
            this.dataGridViewTextBoxColumn39.HeaderText = "Size_type";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Allowance_type";
            this.dataGridViewTextBoxColumn40.HeaderText = "Allowance_type";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Tolerance";
            this.dataGridViewTextBoxColumn41.HeaderText = "Tolerance";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn42.HeaderText = "ID";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // FormOfWorkWithDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 730);
            this.Controls.Add(this.surfaceDataGridView);
            this.Controls.Add(this.operationsDataGridView);
            this.Controls.Add(this.calculationDataGridView);
            this.Controls.Add(this.detailDataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView detailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.BindingSource calculationBindingSource;
        private ChainsDataSet1TableAdapters.OperationsTableAdapter operationsTableAdapter;
        private System.Windows.Forms.DataGridView calculationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private ChainsDataSet1TableAdapters.SurfaceTableAdapter surfaceTableAdapter;
        private System.Windows.Forms.DataGridView operationsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.BindingSource surfaceBindingSource;
        private System.Windows.Forms.DataGridView surfaceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
    }
}