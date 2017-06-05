using System;

namespace WindowsFormsApplication8
{
    
    public partial class FormOfWorkWithDatabase : System.Windows.Forms.Form
    {
        MainForm parrentForm;
        public FormOfWorkWithDatabase(string data, MainForm parrentForm)
        {
            InitializeComponent();
            this.parrentForm = parrentForm;
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet.Calculation". При необходимости она может быть перемещена или удалена.
            this.calculationTableAdapter.Fill(this.chainsDataSet.Calculation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.chainsDataSet.Operations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet.Detail". При необходимости она может быть перемещена или удалена.
            this.detailTableAdapter.Fill(this.chainsDataSet.Detail);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet.Surface". При необходимости она может быть перемещена или удалена.
            this.surfaceTableAdapter.Fill(this.chainsDataSet.Surface);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
                EventClickOnButtonOfSelectPart.buttonSelectPartInFormOfWorkWithDatabase(this, parrentForm);
           }
           catch { }
        }
       
        /*private void button2_Click(object sender, EventArgs e)
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
           /* if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                this.детальTableAdapter.Update(this.juliaDataSet.Деталь);
                this.переходыTableAdapter.Update(this.juliaDataSet.Переходы);
            }
        }*/
    }
}
