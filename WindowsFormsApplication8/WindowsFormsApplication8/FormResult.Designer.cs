namespace WindowsFormsApplication8
{
    partial class FormResult
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
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonSaveToDisk = new System.Windows.Forms.Button();
            this.buttonSaveToBase = new System.Windows.Forms.Button();
            this.SurfacesTreeView = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(273, 3);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(686, 347);
            this.richTextBoxResult.TabIndex = 2;
            this.richTextBoxResult.Text = "";
            // 
            // buttonSaveToDisk
            // 
            this.buttonSaveToDisk.Location = new System.Drawing.Point(2, 3);
            this.buttonSaveToDisk.Name = "buttonSaveToDisk";
            this.buttonSaveToDisk.Size = new System.Drawing.Size(265, 36);
            this.buttonSaveToDisk.TabIndex = 13;
            this.buttonSaveToDisk.Text = "Сохранить в текстовой файл";
            this.buttonSaveToDisk.UseVisualStyleBackColor = true;
            this.buttonSaveToDisk.Click += new System.EventHandler(this.buttonSaveToDisk_Click);
            // 
            // buttonSaveToBase
            // 
            this.buttonSaveToBase.Location = new System.Drawing.Point(2, 45);
            this.buttonSaveToBase.Name = "buttonSaveToBase";
            this.buttonSaveToBase.Size = new System.Drawing.Size(265, 36);
            this.buttonSaveToBase.TabIndex = 14;
            this.buttonSaveToBase.Text = "Сохранить в БД";
            this.buttonSaveToBase.UseVisualStyleBackColor = true;
            this.buttonSaveToBase.Click += new System.EventHandler(this.buttonSaveToBase_Click);
            // 
            // SurfacesTreeView
            // 
            this.SurfacesTreeView.Location = new System.Drawing.Point(2, 86);
            this.SurfacesTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurfacesTreeView.Name = "SurfacesTreeView";
            this.SurfacesTreeView.Size = new System.Drawing.Size(265, 264);
            this.SurfacesTreeView.TabIndex = 15;
            this.SurfacesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SurfacesTreeView_NodeMouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(283, 254);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 96);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 350);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SurfacesTreeView);
            this.Controls.Add(this.buttonSaveToBase);
            this.Controls.Add(this.buttonSaveToDisk);
            this.Controls.Add(this.richTextBoxResult);
            this.Name = "FormResult";
            this.Text = "Результат";
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveToDisk;
        private System.Windows.Forms.Button buttonSaveToBase;
        protected internal System.Windows.Forms.RichTextBox richTextBoxResult;
        protected internal System.Windows.Forms.TreeView SurfacesTreeView;
        protected internal System.Windows.Forms.RichTextBox richTextBox1;
    }
}