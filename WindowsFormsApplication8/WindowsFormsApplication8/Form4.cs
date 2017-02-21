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
    
    public partial class Form4 : Form
    {
        public Form4(string data)
        {
            InitializeComponent();
            this.data = data;
        }
        string data;
 string h;

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
                         
            h = this.dataGridView1.CurrentRow.Cells[3].Value.ToString() + "-" + this.dataGridView1.CurrentRow.Cells[4].Value.ToString() + "-" + this.dataGridView1.CurrentRow.Cells[11].Value.ToString() + "-" + this.dataGridView2.CurrentRow.Cells[4].Value.ToString() +
                "-" + this.dataGridView2.CurrentRow.Cells[5].Value.ToString() + "-" + this.dataGridView2.CurrentRow.Cells[14].Value.ToString() + "-"
                + this.dataGridView2.CurrentRow.Cells[13].Value.ToString() + "-" + this.dataGridView2.CurrentRow.Cells[11].Value.ToString() + "-" + dataGridView2.Rows.Count.ToString();
            int i = Convert.ToInt32(dataGridView2.Rows.Count.ToString());
            for (int u = 1; u < i - 1; u++)
            {
                h = h + "-" + this.dataGridView2[2, u].Value.ToString() + "-" + this.dataGridView2[4, u].Value.ToString() + "-" + this.dataGridView2[5, u].Value.ToString() + "-" + this.dataGridView2[14, u].Value.ToString() + "-" + this.dataGridView2[13, u].Value.ToString() + "-" + "2"/*this.dataGridView2[12, u].Value.ToString()*/ + "-" + "3"/*this.dataGridView2[11, u].Value.ToString()*/;

            }
            
            h =h +"-" + this.dataGridView1.CurrentRow.Cells[8].Value.ToString() + "-" + this.dataGridView1.CurrentRow.Cells[9].Value.ToString() + "-" + this.dataGridView1.CurrentRow.Cells[10].Value.ToString()+ "-"+ this.dataGridView1.CurrentRow.Cells[7].Value.ToString(); ;
            Close();
        }
        public string Data
        {
            get
            {
                return Convert.ToString(h);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
           if (String.IsNullOrEmpty(textBox1.Text)) детальBindingSource.Filter = "";
           else детальBindingSource.Filter = "NaimenovanieDetali = \'" + textBox1.Text + "\'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
