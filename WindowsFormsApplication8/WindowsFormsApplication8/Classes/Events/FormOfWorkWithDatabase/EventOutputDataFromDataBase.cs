using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication8;

namespace WindowsFormsApplication8
{
    class EventOutputDataFromDataBase
    {
        private static DBConnection dbConnection = DBConnection.getDB();
        private static SqlDataAdapter tableDataAdapter = new SqlDataAdapter();

        private static List<DependencePart> parts;
        private static List<DependenceCalculation> calculations;

        Surface technologicalProcess;
       // private static List<Dependence> surfaces;

        public static void getListNamesPartsInComboBox(FormOfWorkWithDatabase form)
        {
            selectPartsInDB();

            form.Part.Items.Clear();

            foreach (DependencePart part in parts)
            {
                form.Part.Items.Add(part.getName());
            }

            try
            {
                form.Part.SelectedIndex = 0;
            }
            catch { }
        }

        /*public static void getListNamesSurfacesInComboBox(FormOfWorkWithDatabase form, int selectedIndex)
        {
            form.Surfaces.Items.Clear();

            selectSurfaceInDB(selectedIndex);

            foreach (Dependence surface in surfaces)
            {
                form.Surfaces.Items.Add(surface.getName());
            }

            try
            {
                form.Surfaces.SelectedIndex = 0;
            }
            catch { }
        }

        private static void selectSurfaceInDB(int index)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();
            
            Dependence calculation = calculations[index];

            dbConnection.GetDataUsingDataAdapter($@"SELECT ID, surface_cipher FROM surface WHERE Cipher_detail = {calculation.getId()}", ref tempDataTable, ref tableDataAdapter);

            List<Dependence> surfaces = new List<Dependence>();

            try
            {
                
                foreach (DataRow row in tempDataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);
                    string name = Convert.ToString(row[1]);

                    surfaces.Add(new Dependence(id, name));
                }

                EventOutputDataFromDataBase.surfaces = surfaces;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }*/



        private static void selectPartsInDB()
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            dbConnection.GetDataUsingDataAdapter($@"SELECT cipher_detail, Name, length_detail FROM detail", ref tempDataTable, ref tableDataAdapter);

            List<DependencePart> parts = new List<DependencePart>();

            try
            {
                foreach(DataRow row in tempDataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);
                    string name = Convert.ToString(row[1]);
                    double length = Convert.ToDouble(row[2]);

                    parts.Add(new DependencePart(id, name, length));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            EventOutputDataFromDataBase.parts = parts;
        }

        public static void TextChangedInComboBoxPart(FormOfWorkWithDatabase form)
        {
            int selectedIndex = form.Part.SelectedIndex;

            form.LengthPart.Text = parts[selectedIndex].getLengthPart().ToString();

            selectCalculationInDB(selectedIndex);

            form.Calculation.Items.Clear();

            foreach (DependenceCalculation date in calculations)
            {
                form.Calculation.Items.Add(date.getDate());
            }
            try
            {
                form.Calculation.SelectedIndex = 0;
            }
            catch { }
        }

        private static void selectCalculationInDB(int index)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            DependencePart part = parts[index];

            dbConnection.GetDataUsingDataAdapter($@"SELECT ID, Date FROM calculation WHERE Cipher_detail = {part.getId()}", ref tempDataTable, ref tableDataAdapter);

            List<DependenceCalculation> calculations = new List<DependenceCalculation>();

            try
            {
                foreach (DataRow row in tempDataTable.Rows)
                {
                    int id = Convert.ToInt32(row[0]);
                    string date = Convert.ToString(row[1]);

                    calculations.Add(new DependenceCalculation(id, date));
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

            //getListNamesSurfacesInComboBox(form, selectedIndex);
        }

        private static void selectTechnologicalProcess(int index, FormOfWorkWithDatabase form)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            DependenceCalculation calculation = calculations[index];

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

        /*private static Dependence searchPartInList(string name)
        {
            foreach(Dependence part in parts)
            {
                if(part.getName() == name)
                {
                    return part;
                }
            }
            return null;
        }*/}
    
}
