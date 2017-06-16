using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication8
{
    class DBConnection
    {
        public string ConnectionString { get; set; }
        public string DBName { get; set; }
        public string ServerName { get; set; }
        private static DBConnection DB = null;

        private DBConnection()
        {
            try
            {
                ConnectionString = File.ReadAllText(@"connectionsString.connstr");
                var temp = ConnectionString.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length < 2)
                {
                    MessageBox.Show("Имя базы данных не было найдено");
                    MessageBox.Show("Имя сервера не было найдено");
                }
                DBName = GetDBNameFromConnectionString(temp);
                ServerName = @"(localdb)\mssqllocaldb";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public static DBConnection getDB()
        {
            if(DBConnection.DB == null)
            {
                DBConnection.DB = new DBConnection();
            }

            return DBConnection.DB;
        }

        private string GetDBNameFromConnectionString(string[] temp)
        {
            foreach (string line in temp)
            {
                if (line.Contains("AttachDbFilename="))
                {
                    return line.Remove(line.IndexOf("AttachDbFilename="), "AttachDbFilename=".Length);
                }
            }
            MessageBox.Show("Имя базы данных не было найдено");
            return "";
        }

        private string GetServerNameFromConnectionString(string[] temp)
        {
            foreach (string line in temp)
            {
                if (line.Contains("Data Source="))
                {
                    return line.Remove(line.IndexOf("Data Source="), "Data Source=".Length);
                }
            }
            MessageBox.Show("Имя сервера не было найдено");
            return "";
        }

        public void GetDataUsingDataAdapter(string selectCommand, ref DataTable bindingSource, ref SqlDataAdapter dataAdapter)//Получение данных через DataAdapter от БД
        {
            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, ConnectionString);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                bindingSource = new DataTable();
                bindingSource.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(bindingSource);
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
                bindingSource = null;
            }
        }

        public void SetQuery(string query)//Отправка сообщения БД
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = query;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                throw exc;
            }
        }

    }
}
