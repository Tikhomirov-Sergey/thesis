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
            this.номерДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDetaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаДеталиLмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диаметрDLМмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.допускTdTLМмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шероховатостьRzМкмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.глубинаhyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типРазмераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типОбработаннойПоверхностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типПрипускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видЗаготовкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oboznacheniePoverhnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.детальBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juliaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПереходыДетальBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерДеталиDataGridViewTextBoxColumn,
            this.naimenovanieDetaliDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.длинаДеталиLмDataGridViewTextBoxColumn,
            this.диаметрDLМмDataGridViewTextBoxColumn,
            this.допускTdTLМмDataGridViewTextBoxColumn,
            this.шероховатостьRzМкмDataGridViewTextBoxColumn,
            this.глубинаhyDataGridViewTextBoxColumn,
            this.типРазмераDataGridViewTextBoxColumn,
            this.типОбработаннойПоверхностиDataGridViewTextBoxColumn,
            this.типПрипускаDataGridViewTextBoxColumn,
            this.видЗаготовкиDataGridViewTextBoxColumn,
            this.oboznacheniePoverhnostiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.детальBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // номерДеталиDataGridViewTextBoxColumn
            // 
            this.номерДеталиDataGridViewTextBoxColumn.DataPropertyName = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.HeaderText = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.Name = "номерДеталиDataGridViewTextBoxColumn";
            this.номерДеталиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naimenovanieDetaliDataGridViewTextBoxColumn
            // 
            this.naimenovanieDetaliDataGridViewTextBoxColumn.DataPropertyName = "NaimenovanieDetali";
            this.naimenovanieDetaliDataGridViewTextBoxColumn.HeaderText = "Наименование детали";
            this.naimenovanieDetaliDataGridViewTextBoxColumn.Name = "naimenovanieDetaliDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // длинаДеталиLмDataGridViewTextBoxColumn
            // 
            this.длинаДеталиLмDataGridViewTextBoxColumn.DataPropertyName = "Длина детали l,м";
            this.длинаДеталиLмDataGridViewTextBoxColumn.HeaderText = "Длина детали l,м";
            this.длинаДеталиLмDataGridViewTextBoxColumn.Name = "длинаДеталиLмDataGridViewTextBoxColumn";
            // 
            // диаметрDLМмDataGridViewTextBoxColumn
            // 
            this.диаметрDLМмDataGridViewTextBoxColumn.DataPropertyName = "Диаметр d(L), мм";
            this.диаметрDLМмDataGridViewTextBoxColumn.HeaderText = "Диаметр d(L), мм";
            this.диаметрDLМмDataGridViewTextBoxColumn.Name = "диаметрDLМмDataGridViewTextBoxColumn";
            // 
            // допускTdTLМмDataGridViewTextBoxColumn
            // 
            this.допускTdTLМмDataGridViewTextBoxColumn.DataPropertyName = "Допуск Td(TL), мм";
            this.допускTdTLМмDataGridViewTextBoxColumn.HeaderText = "Допуск Td(TL), мм";
            this.допускTdTLМмDataGridViewTextBoxColumn.Name = "допускTdTLМмDataGridViewTextBoxColumn";
            // 
            // шероховатостьRzМкмDataGridViewTextBoxColumn
            // 
            this.шероховатостьRzМкмDataGridViewTextBoxColumn.DataPropertyName = "Шероховатость Rz, мкм";
            this.шероховатостьRzМкмDataGridViewTextBoxColumn.HeaderText = "Шероховатость Rz, мкм";
            this.шероховатостьRzМкмDataGridViewTextBoxColumn.Name = "шероховатостьRzМкмDataGridViewTextBoxColumn";
            // 
            // глубинаhyDataGridViewTextBoxColumn
            // 
            this.глубинаhyDataGridViewTextBoxColumn.DataPropertyName = "Глубина(hy)";
            this.глубинаhyDataGridViewTextBoxColumn.HeaderText = "Глубина(hy)";
            this.глубинаhyDataGridViewTextBoxColumn.Name = "глубинаhyDataGridViewTextBoxColumn";
            // 
            // типРазмераDataGridViewTextBoxColumn
            // 
            this.типРазмераDataGridViewTextBoxColumn.DataPropertyName = "Тип размера";
            this.типРазмераDataGridViewTextBoxColumn.HeaderText = "Тип размера";
            this.типРазмераDataGridViewTextBoxColumn.Name = "типРазмераDataGridViewTextBoxColumn";
            // 
            // типОбработаннойПоверхностиDataGridViewTextBoxColumn
            // 
            this.типОбработаннойПоверхностиDataGridViewTextBoxColumn.DataPropertyName = "Тип обработанной поверхности";
            this.типОбработаннойПоверхностиDataGridViewTextBoxColumn.HeaderText = "Тип обработанной поверхности";
            this.типОбработаннойПоверхностиDataGridViewTextBoxColumn.Name = "типОбработаннойПоверхностиDataGridViewTextBoxColumn";
            // 
            // типПрипускаDataGridViewTextBoxColumn
            // 
            this.типПрипускаDataGridViewTextBoxColumn.DataPropertyName = "Тип припуска";
            this.типПрипускаDataGridViewTextBoxColumn.HeaderText = "Тип припуска";
            this.типПрипускаDataGridViewTextBoxColumn.Name = "типПрипускаDataGridViewTextBoxColumn";
            // 
            // видЗаготовкиDataGridViewTextBoxColumn
            // 
            this.видЗаготовкиDataGridViewTextBoxColumn.DataPropertyName = "Вид заготовки";
            this.видЗаготовкиDataGridViewTextBoxColumn.HeaderText = "Вид заготовки";
            this.видЗаготовкиDataGridViewTextBoxColumn.Name = "видЗаготовкиDataGridViewTextBoxColumn";
            // 
            // oboznacheniePoverhnostiDataGridViewTextBoxColumn
            // 
            this.oboznacheniePoverhnostiDataGridViewTextBoxColumn.DataPropertyName = "OboznacheniePoverhnosti";
            this.oboznacheniePoverhnostiDataGridViewTextBoxColumn.HeaderText = "Обозначение поверхности";
            this.oboznacheniePoverhnostiDataGridViewTextBoxColumn.Name = "oboznacheniePoverhnostiDataGridViewTextBoxColumn";
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
            this.dataGridView2.Location = new System.Drawing.Point(101, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1541, 216);
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
            this.button1.Location = new System.Drawing.Point(324, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор\r\nзаписи \r\nиз БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по дате:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
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
            this.button4.Location = new System.Drawing.Point(219, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по\r\nнаименованию\r\nдетали:";
            // 
            // FormOfWorkWithDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 570);
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
            this.Name = "FormOfWorkWithDatabase";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.детальBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juliaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПереходыДетальBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDetaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаДеталиLмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn диаметрDLМмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn допускTdTLМмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шероховатостьRzМкмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn глубинаhyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типРазмераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типОбработаннойПоверхностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типПрипускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видЗаготовкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oboznacheniePoverhnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.DataGridView dataGridView2;
    }
}