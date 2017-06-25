using System;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Server;
using Microsoft.Data.ConnectionUI;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication8
{

    public partial class FormOfWorkWithDatabase : System.Windows.Forms.Form
    {
        public MainForm parrentForm;

        public FormOfWorkWithDatabase(string data, MainForm parrentForm)
        {
            InitializeComponent();
            this.parrentForm = parrentForm;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           EventOutputDataFromDataBase.getListNamesAndCipherPartsInComboBox(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
           {
                EventOutputDataFromDataBase.buttonClickSaveToPart(this);
           }
           catch { }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchByCipher.Text)) detailBindingSource.Filter = "";
            else detailBindingSource.Filter = "Name LIKE'" + SearchByCipher.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchByCipher.Text)) detailBindingSource.Filter = "";
            else detailBindingSource.Filter = "Date = \'" + SearchByCipher.Text + "\'";
        }

        private void detailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chainsDataSet1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HoleDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void NamePart_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.selectedIndexNamePartChanged(this);
        }

        private void CipherPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.selectedIndexCipherPartChange(this);
        }

        private void Surfaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.selectedIndexComboBoxSurfaceChange(this);
        }

        private void Calculation_SelectedIndexChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.selectedIndexComboBoxCalculationChange(this);
        }

        private void SearchByName_TextChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.searchByName(this);
        }
    }
}
