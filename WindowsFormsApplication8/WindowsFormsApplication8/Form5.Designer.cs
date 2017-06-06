namespace WindowsFormsApplication8
{
    partial class Form5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chainsDataSet1 = new WindowsFormsApplication8.ChainsDataSet1();
            this.detailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.DetailTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.TableAdapterManager();
            this.detailDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.calculationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculationTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.CalculationTableAdapter();
            this.calculationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.OperationsTableAdapter();
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.surfaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surfaceTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.SurfaceTableAdapter();
            this.surfaceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operations_and_ResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operations_and_ResultsTableAdapter = new WindowsFormsApplication8.ChainsDataSet1TableAdapters.Operations_and_ResultsTableAdapter();
            this.iDoperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDsurfaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operations_and_ResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите наименование детали:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите обозначение поверхности:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 160);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 22);
            this.textBox2.TabIndex = 7;
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
            this.tableAdapterManager.Operations_and_ResultsTableAdapter = this.operations_and_ResultsTableAdapter;
            this.tableAdapterManager.OperationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.SurfaceTableAdapter = this.surfaceTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication8.ChainsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detailDataGridView
            // 
            this.detailDataGridView.AutoGenerateColumns = false;
            this.detailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.detailDataGridView.DataSource = this.detailBindingSource;
            this.detailDataGridView.Location = new System.Drawing.Point(550, 7);
            this.detailDataGridView.Name = "detailDataGridView";
            this.detailDataGridView.RowTemplate.Height = 24;
            this.detailDataGridView.Size = new System.Drawing.Size(460, 175);
            this.detailDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cipher_detail";
            this.dataGridViewTextBoxColumn2.HeaderText = "cipher_detail";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "length_detail";
            this.dataGridViewTextBoxColumn4.HeaderText = "length_detail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = true;
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
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.calculationDataGridView.DataSource = this.calculationBindingSource;
            this.calculationDataGridView.Location = new System.Drawing.Point(93, 233);
            this.calculationDataGridView.Name = "calculationDataGridView";
            this.calculationDataGridView.RowTemplate.Height = 24;
            this.calculationDataGridView.Size = new System.Drawing.Size(300, 220);
            this.calculationDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cipher_detail";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cipher_detail";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            this.iDoperationDataGridViewTextBoxColumn,
            this.iDsurfaceDataGridViewTextBoxColumn});
            this.operationsDataGridView.DataSource = this.operations_and_ResultsBindingSource;
            this.operationsDataGridView.Location = new System.Drawing.Point(824, 233);
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.RowTemplate.Height = 24;
            this.operationsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.operationsDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.surfaceDataGridView.DataSource = this.surfaceBindingSource;
            this.surfaceDataGridView.Location = new System.Drawing.Point(446, 233);
            this.surfaceDataGridView.Name = "surfaceDataGridView";
            this.surfaceDataGridView.RowTemplate.Height = 24;
            this.surfaceDataGridView.Size = new System.Drawing.Size(300, 220);
            this.surfaceDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Surface_cipher";
            this.dataGridViewTextBoxColumn14.HeaderText = "Surface_cipher";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Cipher_detail";
            this.dataGridViewTextBoxColumn15.HeaderText = "Cipher_detail";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "View";
            this.dataGridViewTextBoxColumn16.HeaderText = "View";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Diameter";
            this.dataGridViewTextBoxColumn17.HeaderText = "Diameter";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Size_type";
            this.dataGridViewTextBoxColumn18.HeaderText = "Size_type";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Allowance_type";
            this.dataGridViewTextBoxColumn19.HeaderText = "Allowance_type";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Tolerance";
            this.dataGridViewTextBoxColumn20.HeaderText = "Tolerance";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn21.HeaderText = "ID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // operations_and_ResultsBindingSource
            // 
            this.operations_and_ResultsBindingSource.DataMember = "Operations_and_Results";
            this.operations_and_ResultsBindingSource.DataSource = this.chainsDataSet1;
            // 
            // operations_and_ResultsTableAdapter
            // 
            this.operations_and_ResultsTableAdapter.ClearBeforeFill = true;
            // 
            // iDoperationDataGridViewTextBoxColumn
            // 
            this.iDoperationDataGridViewTextBoxColumn.DataPropertyName = "ID_operation";
            this.iDoperationDataGridViewTextBoxColumn.HeaderText = "ID_operation";
            this.iDoperationDataGridViewTextBoxColumn.Name = "iDoperationDataGridViewTextBoxColumn";
            // 
            // iDsurfaceDataGridViewTextBoxColumn
            // 
            this.iDsurfaceDataGridViewTextBoxColumn.DataPropertyName = "ID_surface";
            this.iDsurfaceDataGridViewTextBoxColumn.HeaderText = "ID_surface";
            this.iDsurfaceDataGridViewTextBoxColumn.Name = "iDsurfaceDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 539);
            this.Controls.Add(this.surfaceDataGridView);
            this.Controls.Add(this.operationsDataGridView);
            this.Controls.Add(this.calculationDataGridView);
            this.Controls.Add(this.detailDataGridView);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Сохранение в БД";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chainsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operations_and_ResultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dlinadetaliLмDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn обозначениеПоверхностиDataGridViewTextBoxColumn;
        protected internal System.Windows.Forms.TextBox textBox1;
        protected internal System.Windows.Forms.TextBox textBox2;
        private ChainsDataSet1 chainsDataSet1;
        private System.Windows.Forms.BindingSource detailBindingSource;
        protected internal ChainsDataSet1TableAdapters.DetailTableAdapter detailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        protected internal System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView surfaceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        protected internal ChainsDataSet1TableAdapters.CalculationTableAdapter calculationTableAdapter;
        protected internal System.Windows.Forms.BindingSource calculationBindingSource;
        protected internal ChainsDataSet1TableAdapters.OperationsTableAdapter operationsTableAdapter;
        protected internal System.Windows.Forms.DataGridView calculationDataGridView;
        protected internal System.Windows.Forms.BindingSource operationsBindingSource;
        protected internal ChainsDataSet1TableAdapters.SurfaceTableAdapter surfaceTableAdapter;
        protected internal System.Windows.Forms.DataGridView operationsDataGridView;
        protected internal System.Windows.Forms.BindingSource surfaceBindingSource;
        protected internal ChainsDataSet1TableAdapters.Operations_and_ResultsTableAdapter operations_and_ResultsTableAdapter;
        protected internal System.Windows.Forms.BindingSource operations_and_ResultsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDoperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsurfaceDataGridViewTextBoxColumn;
        protected internal ChainsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        protected internal System.Windows.Forms.DataGridView detailDataGridView;
    }
}