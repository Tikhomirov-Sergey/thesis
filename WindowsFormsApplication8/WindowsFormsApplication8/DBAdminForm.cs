using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Smo;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace WindowsFormsApplication8
{
    public partial class DBAdminForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        SqlDataAdapter tableDataAdapter = new SqlDataAdapter();

        public DBAdminForm()
        {
            InitializeComponent();
        }

        private void DBAdminForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter tempDataAdapter = new SqlDataAdapter();
            DataTable tablesDataTable = new DataTable();
            dbConnection.GetDataUsingDataAdapter(@"SELECT * FROM sys.objects WHERE type in (N'U')", ref tablesDataTable, ref tempDataAdapter);
            if (tablesDataTable != null)
            {
                foreach (DataRow table in tablesDataTable.Rows)
                {
                    tablesComboBox.Items.Add(table[0]);
                }
            }
        }

        private void tablesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tempDataTable = new DataTable();
            dbConnection.GetDataUsingDataAdapter($@"SELECT * FROM [{tablesComboBox.Text}]", ref tempDataTable, ref tableDataAdapter);
            try
            {
                DBdataGridView.DataSource = tempDataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                tableDataAdapter.Update((DataTable)DBdataGridView.DataSource);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
    }
}
