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
    public partial class FormSaveToDataBase : Form
    {
        private DBConnection dbConnection = DBConnection.getDB();
        private SqlDataAdapter tableDataAdapter = new SqlDataAdapter();

        public FormSaveToDataBase()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EventClickOnButtonOfSaveToDatabase.buttonSaveToDatabase(this);
        }
    }
}
