using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.IO;


namespace WindowsFormsApplication8
{
    
    public partial class FormOfWorkWithDatabase : Form
    {
        MainForm parrentForm;
        public FormOfWorkWithDatabase(string data, MainForm parrentForm)
        {
            InitializeComponent();
            this.parrentForm = parrentForm;
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Переходы". При необходимости она может быть перемещена или удалена.
            this.переходыTableAdapter.Fill(this.juliaDataSet.Переходы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Деталь". При необходимости она может быть перемещена или удалена.
            this.детальTableAdapter.Fill(this.juliaDataSet.Деталь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Деталь". При необходимости она может быть перемещена или удалена.
            this.детальTableAdapter.Fill(this.juliaDataSet.Деталь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Переходы". При необходимости она может быть перемещена или удалена.
            this.переходыTableAdapter.Fill(this.juliaDataSet.Переходы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "juliaDataSet.Деталь". При необходимости она может быть перемещена или удалена.
            this.детальTableAdapter.Fill(this.juliaDataSet.Деталь);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EventClickOnButtonOfSelectPart.buttonSelectPartInFormOfWorkWithDatabase(this, parrentForm);
            }
            catch { }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(textBox1.Text)) детальBindingSource.Filter = "";
           else детальBindingSource.Filter = "NaimenovanieDetali = \'" + textBox1.Text + "\'";
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text)) детальBindingSource.Filter = "";
            else детальBindingSource.Filter = "Дата = \'" + textBox2.Text + "\'";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                this.детальTableAdapter.Update(this.juliaDataSet.Деталь);
                this.переходыTableAdapter.Update(this.juliaDataSet.Переходы);
            }
        }
    }
}
