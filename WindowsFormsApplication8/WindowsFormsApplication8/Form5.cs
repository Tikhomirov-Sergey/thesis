using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication8
{
    public partial class Form5 : Form
    {
        private DBConnection dbConnection = DBConnection.getDB();
        private SqlDataAdapter tableDataAdapter = new SqlDataAdapter();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet1.Surface". При необходимости она может быть перемещена или удалена.
            this.surfaceTableAdapter.Fill(this.chainsDataSet1.Surface);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet1.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.chainsDataSet1.Operations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet1.Calculation". При необходимости она может быть перемещена или удалена.
            this.calculationTableAdapter.Fill(this.chainsDataSet1.Calculation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "chainsDataSet1.Detail". При необходимости она может быть перемещена или удалена.
            this.detailTableAdapter.Fill(this.chainsDataSet1.Detail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventClickOnButtonOfSaveToDatabase.buttonSaveToDatabase(this);
        }
    }
}
