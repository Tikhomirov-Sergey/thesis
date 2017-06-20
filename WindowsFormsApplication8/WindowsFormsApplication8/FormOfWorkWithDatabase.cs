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
           EventOutputDataFromDataBase.getListNamesPartsInComboBox(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // try
           // {
                EventOutputDataFromDataBase.buttonClickSaveToPart(this);
          //  }
          //  catch { }
        }

        /*private void ToolStripMenuItemBackup_Click(object sender, EventArgs e)
        {
            const string sqlServerInstanceName = "LAPTOP-OFSP8DM4"; // args[0];
            const string databaseName = "Chains"; // args[1];
            const string databaseBackupName = "Chains.bak";  // args[2];
            
            try
            {

                var server = ;
                string databaseBackupFilePath = Path.Combine(server.Settings.BackupDirectory, databaseBackupName);

                var backup = new Backup
                {
                    Action = BackupActionType.Database,
                    Database = databaseName,
                    Initialize = true, // Все наборы данных бэкапа будут перезаписаны.
                    Incremental = false // Показываем, что это полный бэкап.
                };
                // Устанавливаем файл бэкапа бд.
                var deviceItem = new BackupDeviceItem(databaseBackupFilePath, DeviceType.File);
                backup.Devices.Add(deviceItem);
                backup.SqlBackup(server);
                MessageBox.Show("Резервное копирование базы данных «{0}» выполнено успешно в «{1}». Для продолжения нажмите Enter..." + databaseName + databaseBackupFilePath);
            }
            catch (Exception exception)
            {
                const string fileName = "errorLog.txt";
                File.WriteAllText(fileName, exception.ToString());
                MessageBox.Show("Резервное копирование базы данных «{0}» завершилось неудачно. Смотри лог ошибки в «{1}». Для продолжения нажмите Enter..." + databaseName + fileName);
            }
        }*/


        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text)) detailBindingSource.Filter = "";
            else detailBindingSource.Filter = "Name LIKE'" + textBox1.Text + "%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text)) detailBindingSource.Filter = "";
            else detailBindingSource.Filter = "Date = \'" + textBox2.Text + "\'";
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

        private void detailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chainsDataSet1);

        }

        private void Part_TextChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.TextChangedInComboBoxPart(this);
        }

        private void Calculation_TextChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.TextChangedInComboBoxCalculation(this);
        }

        private void Surfaces_TextChanged(object sender, EventArgs e)
        {
            EventOutputDataFromDataBase.TextChangedInComboBoxSurface(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
