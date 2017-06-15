using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventOutputDataFromDataBase
    {
        private static DBConnection dbConnection = DBConnection.getDB();
        private static SqlDataAdapter tableDataAdapter = new SqlDataAdapter();

        private static List<Dependence> parts;
        private static List<Dependence> calculations;

        public static void getListNamesPartsInComboBox(FormOfWorkWithDatabase form)
        {
            selectPartsInDB();

            form.Part.Items.Clear();

            foreach (Dependence part in parts)
            {
                form.Part.Items.Add(part.getName());
            }

            form.Part.SelectedIndex = 0;
        }

        private static void selectPartsInDB()
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            dbConnection.GetDataUsingDataAdapter($@"SELECT cipher_detail, Name FROM detail", ref tempDataTable, ref tableDataAdapter);

            List<Dependence> namesParts = new List<Dependence>();

            try
            {
                foreach(DataRow row in tempDataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);
                    string name = Convert.ToString(row[1]);

                    namesParts.Add(new Dependence(id, name));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            parts = namesParts;
        }

        public static void TextChangedInComboBoxPart(FormOfWorkWithDatabase form)
        {
            int selectedIndex = form.Part.SelectedIndex;

            selectCalculationInDB(selectedIndex);

            form.Calculation.Items.Clear();

            foreach (Dependence date in calculations)
            {
                form.Calculation.Items.Add(date.getName());
            }

            form.Calculation.SelectedIndex = 0;
        }

        private static void selectCalculationInDB(int index)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            Dependence part = parts[index];

            dbConnection.GetDataUsingDataAdapter($@"SELECT ID, Date FROM calculation WHERE Cipher_detail = {part.getId()}", ref tempDataTable, ref tableDataAdapter);

            List<Dependence> calculations = new List<Dependence>();

            try
            {
                foreach (DataRow row in tempDataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);
                    string date = Convert.ToString(row[1]);

                    calculations.Add(new Dependence(id, date));
                }

                EventOutputDataFromDataBase.calculations = calculations;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void TextChangedInComboBoxCalculation(FormOfWorkWithDatabase form)
        {
            int selectedIndex = form.Calculation.SelectedIndex;

            selectTechnologicalProcess(selectedIndex, form);
        }

        private static void selectTechnologicalProcess(int index, FormOfWorkWithDatabase form)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            Dependence calculation = calculations[index];

            dbConnection.GetDataUsingDataAdapter($@"SELECT * FROM Operations WHERE ID_calculation = {calculation.getId()}", ref tempDataTable, ref tableDataAdapter);
            try
            {
                form.TechnologicalProcess.DataSource = tempDataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private static Dependence searchPartInList(string name)
        {
            foreach(Dependence part in parts)
            {
                if(part.getName() == name)
                {
                    return part;
                }
            }
            return null;
        }


        class Dependence
        {
            private int id;
            private string name;

            public Dependence(int id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public int getId()
            {
                return id;
            }

            public string getName()
            {
                return name;
            }
        }


    }
}
