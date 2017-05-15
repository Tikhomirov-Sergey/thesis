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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.детальBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juliaDataSet = new WindowsFormsApplication8.juliaDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерДеталиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПереходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.переходDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.приспособлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шероховатостьRzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.глубинаHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.смещениеΡDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.погрешностьΕDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.допускTdTLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ziNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диаметрDLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idПриспособленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pcmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.квалитетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKПереходыДетальBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.детальTableAdapter = new WindowsFormsApplication8.juliaDataSetTableAdapters.ДетальTableAdapter();
            this.переходыTableAdapter = new WindowsFormsApplication8.juliaDataSetTableAdapters.ПереходыTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chainsDataSet = new WindowsFormsApplication8.ChainsDataSet();
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceTableAdapter = new WindowsFormsApplication8.ChainsDataSetTableAdapters.SurfaceTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication8.ChainsDataSetTableAdapters.TableAdapterManager();
            this.surfacecipherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cipherdetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowancetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детальBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juliaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПереходыДетальBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surfacecipherDataGridViewTextBoxColumn,
            this.cipherdetailDataGridViewTextBoxColumn,
            this.viewDataGridViewTextBoxColumn,
            this.diameterDataGridViewTextBoxColumn,
            this.sizetypeDataGridViewTextBoxColumn,
            this.allowancetypeDataGridViewTextBoxColumn,
            this.toleranceDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.surfaceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1795, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // детальBindingSource
            // 
            this.детальBindingSource.DataMember = "Деталь";
            this.детальBindingSource.DataSource = this.bindingSource;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.juliaDataSet;
            this.bindingSource.Position = 0;
            // 
            // juliaDataSet
            // 
            this.juliaDataSet.DataSetName = "juliaDataSet";
            this.juliaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДеталиDataGridViewTextBoxColumn1,
            this.номерПереходаDataGridViewTextBoxColumn,
            this.переходDataGridViewTextBoxColumn,
            this.приспособлениеDataGridViewTextBoxColumn,
            this.шероховатостьRzDataGridViewTextBoxColumn,
            this.глубинаHDataGridViewTextBoxColumn,
            this.смещениеΡDataGridViewTextBoxColumn,
            this.погрешностьΕDataGridViewTextBoxColumn,
            this.допускTdTLDataGridViewTextBoxColumn,
            this.ziNomDataGridViewTextBoxColumn,
            this.диаметрDLDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.idПриспособленияDataGridViewTextBoxColumn,
            this.pcmDataGridViewTextBoxColumn,
            this.квалитетDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKПереходыДетальBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.Location = new System.Drawing.Point(-45, 369);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1984, 266);
            this.dataGridView2.TabIndex = 1;
            // 
            // номерДеталиDataGridViewTextBoxColumn1
            // 
            this.номерДеталиDataGridViewTextBoxColumn1.DataPropertyName = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn1.HeaderText = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn1.Name = "номерДеталиDataGridViewTextBoxColumn1";
            // 
            // номерПереходаDataGridViewTextBoxColumn
            // 
            this.номерПереходаDataGridViewTextBoxColumn.DataPropertyName = "Номер перехода";
            this.номерПереходаDataGridViewTextBoxColumn.HeaderText = "Номер перехода";
            this.номерПереходаDataGridViewTextBoxColumn.Name = "номерПереходаDataGridViewTextBoxColumn";
            // 
            // переходDataGridViewTextBoxColumn
            // 
            this.переходDataGridViewTextBoxColumn.DataPropertyName = "Переход";
            this.переходDataGridViewTextBoxColumn.HeaderText = "Переход";
            this.переходDataGridViewTextBoxColumn.Name = "переходDataGridViewTextBoxColumn";
            // 
            // приспособлениеDataGridViewTextBoxColumn
            // 
            this.приспособлениеDataGridViewTextBoxColumn.DataPropertyName = "Приспособление";
            this.приспособлениеDataGridViewTextBoxColumn.HeaderText = "Приспособление";
            this.приспособлениеDataGridViewTextBoxColumn.Name = "приспособлениеDataGridViewTextBoxColumn";
            // 
            // шероховатостьRzDataGridViewTextBoxColumn
            // 
            this.шероховатостьRzDataGridViewTextBoxColumn.DataPropertyName = "Шероховатость Rz";
            this.шероховатостьRzDataGridViewTextBoxColumn.HeaderText = "Шероховатость Rz";
            this.шероховатостьRzDataGridViewTextBoxColumn.Name = "шероховатостьRzDataGridViewTextBoxColumn";
            // 
            // глубинаHDataGridViewTextBoxColumn
            // 
            this.глубинаHDataGridViewTextBoxColumn.DataPropertyName = "Глубина h";
            this.глубинаHDataGridViewTextBoxColumn.HeaderText = "Глубина h";
            this.глубинаHDataGridViewTextBoxColumn.Name = "глубинаHDataGridViewTextBoxColumn";
            // 
            // смещениеΡDataGridViewTextBoxColumn
            // 
            this.смещениеΡDataGridViewTextBoxColumn.DataPropertyName = "Смещение ρ";
            this.смещениеΡDataGridViewTextBoxColumn.HeaderText = "Смещение ρ";
            this.смещениеΡDataGridViewTextBoxColumn.Name = "смещениеΡDataGridViewTextBoxColumn";
            // 
            // погрешностьΕDataGridViewTextBoxColumn
            // 
            this.погрешностьΕDataGridViewTextBoxColumn.DataPropertyName = "Погрешность ε";
            this.погрешностьΕDataGridViewTextBoxColumn.HeaderText = "Погрешность ε";
            this.погрешностьΕDataGridViewTextBoxColumn.Name = "погрешностьΕDataGridViewTextBoxColumn";
            // 
            // допускTdTLDataGridViewTextBoxColumn
            // 
            this.допускTdTLDataGridViewTextBoxColumn.DataPropertyName = "Допуск Td(TL)";
            this.допускTdTLDataGridViewTextBoxColumn.HeaderText = "Допуск Td(TL)";
            this.допускTdTLDataGridViewTextBoxColumn.Name = "допускTdTLDataGridViewTextBoxColumn";
            // 
            // ziNomDataGridViewTextBoxColumn
            // 
            this.ziNomDataGridViewTextBoxColumn.DataPropertyName = "zi nom";
            this.ziNomDataGridViewTextBoxColumn.HeaderText = "zi nom";
            this.ziNomDataGridViewTextBoxColumn.Name = "ziNomDataGridViewTextBoxColumn";
            // 
            // диаметрDLDataGridViewTextBoxColumn
            // 
            this.диаметрDLDataGridViewTextBoxColumn.DataPropertyName = "Диаметр d(L)";
            this.диаметрDLDataGridViewTextBoxColumn.HeaderText = "Диаметр d(L)";
            this.диаметрDLDataGridViewTextBoxColumn.Name = "диаметрDLDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // idПриспособленияDataGridViewTextBoxColumn
            // 
            this.idПриспособленияDataGridViewTextBoxColumn.DataPropertyName = "id приспособления";
            this.idПриспособленияDataGridViewTextBoxColumn.HeaderText = "id приспособления";
            this.idПриспособленияDataGridViewTextBoxColumn.Name = "idПриспособленияDataGridViewTextBoxColumn";
            // 
            // pcmDataGridViewTextBoxColumn
            // 
            this.pcmDataGridViewTextBoxColumn.DataPropertyName = "Pcm";
            this.pcmDataGridViewTextBoxColumn.HeaderText = "Pcm";
            this.pcmDataGridViewTextBoxColumn.Name = "pcmDataGridViewTextBoxColumn";
            // 
            // квалитетDataGridViewTextBoxColumn
            // 
            this.квалитетDataGridViewTextBoxColumn.DataPropertyName = "Квалитет";
            this.квалитетDataGridViewTextBoxColumn.HeaderText = "Квалитет";
            this.квалитетDataGridViewTextBoxColumn.Name = "квалитетDataGridViewTextBoxColumn";
            // 
            // fKПереходыДетальBindingSource
            // 
            this.fKПереходыДетальBindingSource.DataMember = "FK_Переходы_Деталь";
            this.fKПереходыДетальBindingSource.DataSource = this.детальBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор\r\nзаписи \r\nиз БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по дате:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(556, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 68);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удаление\r\nзаписи \r\nиз БД";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // детальTableAdapter
            // 
            this.детальTableAdapter.ClearBeforeFill = true;
            // 
            // переходыTableAdapter
            // 
            this.переходыTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(106, 51);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по\r\nнаименованию\r\nдетали:";
            // 
            // chainsDataSet
            // 
            this.chainsDataSet.DataSetName = "ChainsDataSet";
            this.chainsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // surfaceBindingSource
            // 
            this.surfaceBindingSource.DataMember = "Surface";
            this.surfaceBindingSource.DataSource = this.chainsDataSet;
            // 
            // surfaceTableAdapter
            // 
            this.surfaceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CalculationTableAdapter = null;
            this.tableAdapterManager.ChamferTableAdapter = null;
            this.tableAdapterManager.DetailTableAdapter = null;
            this.tableAdapterManager.Operations_and_ResultsTableAdapter = null;
            this.tableAdapterManager.OperationsTableAdapter = null;
            this.tableAdapterManager.SurfaceTableAdapter = this.surfaceTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication8.ChainsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // surfacecipherDataGridViewTextBoxColumn
            // 
            this.surfacecipherDataGridViewTextBoxColumn.DataPropertyName = "Surface_cipher";
            this.surfacecipherDataGridViewTextBoxColumn.HeaderText = "Surface_cipher";
            this.surfacecipherDataGridViewTextBoxColumn.Name = "surfacecipherDataGridViewTextBoxColumn";
            // 
            // cipherdetailDataGridViewTextBoxColumn
            // 
            this.cipherdetailDataGridViewTextBoxColumn.DataPropertyName = "Cipher_detail";
            this.cipherdetailDataGridViewTextBoxColumn.HeaderText = "Cipher_detail";
            this.cipherdetailDataGridViewTextBoxColumn.Name = "cipherdetailDataGridViewTextBoxColumn";
            // 
            // viewDataGridViewTextBoxColumn
            // 
            this.viewDataGridViewTextBoxColumn.DataPropertyName = "View";
            this.viewDataGridViewTextBoxColumn.HeaderText = "View";
            this.viewDataGridViewTextBoxColumn.Name = "viewDataGridViewTextBoxColumn";
            // 
            // diameterDataGridViewTextBoxColumn
            // 
            this.diameterDataGridViewTextBoxColumn.DataPropertyName = "Diameter";
            this.diameterDataGridViewTextBoxColumn.HeaderText = "Diameter";
            this.diameterDataGridViewTextBoxColumn.Name = "diameterDataGridViewTextBoxColumn";
            // 
            // sizetypeDataGridViewTextBoxColumn
            // 
            this.sizetypeDataGridViewTextBoxColumn.DataPropertyName = "Size_type";
            this.sizetypeDataGridViewTextBoxColumn.HeaderText = "Size_type";
            this.sizetypeDataGridViewTextBoxColumn.Name = "sizetypeDataGridViewTextBoxColumn";
            // 
            // allowancetypeDataGridViewTextBoxColumn
            // 
            this.allowancetypeDataGridViewTextBoxColumn.DataPropertyName = "Allowance_type";
            this.allowancetypeDataGridViewTextBoxColumn.HeaderText = "Allowance_type";
            this.allowancetypeDataGridViewTextBoxColumn.Name = "allowancetypeDataGridViewTextBoxColumn";
            // 
            // toleranceDataGridViewTextBoxColumn
            // 
            this.toleranceDataGridViewTextBoxColumn.DataPropertyName = "Tolerance";
            this.toleranceDataGridViewTextBoxColumn.HeaderText = "Tolerance";
            this.toleranceDataGridViewTextBoxColumn.Name = "toleranceDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // FormOfWorkWithDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOfWorkWithDatabase";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детальBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juliaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПереходыДетальBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource;
        private juliaDataSet juliaDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinadetaliLмDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource детальBindingSource;
        private System.Windows.Forms.BindingSource fKПереходыДетальBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПереходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn переходDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn приспособлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шероховатостьRzDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn глубинаHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn смещениеΡDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn погрешностьΕDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn допускTdTLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ziNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn диаметрDLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idПриспособленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn квалитетDataGridViewTextBoxColumn;
        public juliaDataSetTableAdapters.ДетальTableAdapter детальTableAdapter;
        public juliaDataSetTableAdapters.ПереходыTableAdapter переходыTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.DataGridView dataGridView2;
        private ChainsDataSet chainsDataSet;
        private System.Windows.Forms.BindingSource surfaceBindingSource;
        private ChainsDataSetTableAdapters.SurfaceTableAdapter surfaceTableAdapter;
        private ChainsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfacecipherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cipherdetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowancetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
    }
}