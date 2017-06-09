using System;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Server;
using Microsoft.Data.ConnectionUI;
using System.IO;
using System.Windows.Forms;

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
            try
            {
                EventClickOnButtonOfSelectPart.buttonSelectPartInFormOfWorkWithDatabase(this, parrentForm);

            }
            catch { }
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
    }
}
