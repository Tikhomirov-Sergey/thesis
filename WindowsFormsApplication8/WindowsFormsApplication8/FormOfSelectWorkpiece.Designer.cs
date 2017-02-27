namespace WindowsFormsApplication8
{
    partial class FormOfSelectWorkpiece
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
            this.TreeOfWorkpiece = new System.Windows.Forms.TreeView();
            this.ChoiceOfWorkpiece = new System.Windows.Forms.Button();
            this.SurfaceRoughnessRz = new System.Windows.Forms.TextBox();
            this.ThicknessOfDefectiveCoating = new System.Windows.Forms.TextBox();
            this.NameOfWorkpiece = new System.Windows.Forms.TextBox();
            this.Kvalitet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValidOffsetSurface = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SurfaceRoughnessRa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TreeOfWorkpiece
            // 
            this.TreeOfWorkpiece.Location = new System.Drawing.Point(12, 167);
            this.TreeOfWorkpiece.Name = "TreeOfWorkpiece";
            this.TreeOfWorkpiece.ShowLines = false;
            this.TreeOfWorkpiece.ShowPlusMinus = false;
            this.TreeOfWorkpiece.ShowRootLines = false;
            this.TreeOfWorkpiece.Size = new System.Drawing.Size(483, 301);
            this.TreeOfWorkpiece.TabIndex = 0;
            this.TreeOfWorkpiece.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeOfWorkpiece_AfterSelect);
            this.TreeOfWorkpiece.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // ChoiceOfWorkpiece
            // 
            this.ChoiceOfWorkpiece.Location = new System.Drawing.Point(501, 167);
            this.ChoiceOfWorkpiece.Name = "ChoiceOfWorkpiece";
            this.ChoiceOfWorkpiece.Size = new System.Drawing.Size(92, 300);
            this.ChoiceOfWorkpiece.TabIndex = 1;
            this.ChoiceOfWorkpiece.Text = "Выбрать заготовку";
            this.ChoiceOfWorkpiece.UseVisualStyleBackColor = true;
            this.ChoiceOfWorkpiece.Click += new System.EventHandler(this.button1_Click);
            // 
            // SurfaceRoughnessRz
            // 
            this.SurfaceRoughnessRz.Location = new System.Drawing.Point(502, 38);
            this.SurfaceRoughnessRz.Name = "SurfaceRoughnessRz";
            this.SurfaceRoughnessRz.Size = new System.Drawing.Size(91, 20);
            this.SurfaceRoughnessRz.TabIndex = 2;
            this.SurfaceRoughnessRz.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SurfaceRoughnessRz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // ThicknessOfDefectiveCoating
            // 
            this.ThicknessOfDefectiveCoating.Location = new System.Drawing.Point(502, 87);
            this.ThicknessOfDefectiveCoating.Name = "ThicknessOfDefectiveCoating";
            this.ThicknessOfDefectiveCoating.Size = new System.Drawing.Size(91, 20);
            this.ThicknessOfDefectiveCoating.TabIndex = 3;
            this.ThicknessOfDefectiveCoating.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // NameOfWorkpiece
            // 
            this.NameOfWorkpiece.Location = new System.Drawing.Point(302, 12);
            this.NameOfWorkpiece.Name = "NameOfWorkpiece";
            this.NameOfWorkpiece.Size = new System.Drawing.Size(291, 20);
            this.NameOfWorkpiece.TabIndex = 4;
            // 
            // Kvalitet
            // 
            this.Kvalitet.Location = new System.Drawing.Point(502, 114);
            this.Kvalitet.Name = "Kvalitet";
            this.Kvalitet.Size = new System.Drawing.Size(91, 20);
            this.Kvalitet.TabIndex = 6;
            this.Kvalitet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Достигаемая шероховатость, Rz, мм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Глубина дефектного слоя, h,мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Достигаемая точность, IT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(457, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ρ";
            // 
            // ValidOffsetSurface
            // 
            this.ValidOffsetSurface.Location = new System.Drawing.Point(502, 140);
            this.ValidOffsetSurface.Name = "ValidOffsetSurface";
            this.ValidOffsetSurface.Size = new System.Drawing.Size(91, 20);
            this.ValidOffsetSurface.TabIndex = 11;
            this.ValidOffsetSurface.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ",мм";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Допускаемое смещение по поверхности,";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Достигаемая шероховатость, Ra, мкм";
            // 
            // SurfaceRoughnessRa
            // 
            this.SurfaceRoughnessRa.Location = new System.Drawing.Point(502, 62);
            this.SurfaceRoughnessRa.Name = "SurfaceRoughnessRa";
            this.SurfaceRoughnessRa.Size = new System.Drawing.Size(91, 20);
            this.SurfaceRoughnessRa.TabIndex = 14;
            this.SurfaceRoughnessRa.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.SurfaceRoughnessRa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressForTextBoxWithDouble);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SurfaceRoughnessRa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValidOffsetSurface);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kvalitet);
            this.Controls.Add(this.NameOfWorkpiece);
            this.Controls.Add(this.ThicknessOfDefectiveCoating);
            this.Controls.Add(this.SurfaceRoughnessRz);
            this.Controls.Add(this.ChoiceOfWorkpiece);
            this.Controls.Add(this.TreeOfWorkpiece);
            this.Name = "Form2";
            this.Text = "Выбор заготовки";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TreeOfWorkpiece;
        private System.Windows.Forms.Button ChoiceOfWorkpiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox SurfaceRoughnessRz;
        public System.Windows.Forms.TextBox ThicknessOfDefectiveCoating;
        public System.Windows.Forms.TextBox NameOfWorkpiece;
        public System.Windows.Forms.TextBox Kvalitet;
        public System.Windows.Forms.TextBox ValidOffsetSurface;
        public System.Windows.Forms.TextBox SurfaceRoughnessRa;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
    }
}