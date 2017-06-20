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

        private static DependenceWorkpriece workpriece;
        private static List<DependenceOperationInTechnologicalProcess> technologicalProcess;
        private static List<DependenceSurface> surfaces;
        private static List<DependenceOperation> operations;


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

        public static void TextChangedInComboBoxCalculation(FormOfWorkWithDatabase form)
        {
            int selectedIndex = form.Calculation.SelectedIndex;

            selectTechnologicalProcess(selectedIndex, form);
            getTechnologicalProcessInTreeView(form);

            getSurfacesInComboBoxAndTextBoxes(form, selectedIndex);
        }

        public static void TextChangedInComboBoxSurface(FormOfWorkWithDatabase form)
        {
            int selectedIndex = form.Surfaces.SelectedIndex;
            selectOperationInDB(selectedIndex);

            try
            {
                insertParametersIntextBox(form, selectedIndex);
                insertOperationsInTreeView(form);
            }
            catch{ }
        }

        public static void getSurfacesInComboBoxAndTextBoxes(FormOfWorkWithDatabase form, int selectedIndex)
        {
            form.Surfaces.Items.Clear();

            selectSurfaceInDB(form, selectedIndex);

            foreach (DependenceSurface surface in surfaces)
            {
                form.Surfaces.Items.Add(surface.getNameSurface());
            }

            try
            {
                form.Surfaces.SelectedIndex = 0;
            }
            catch { }
        }

        public static void buttonClickSaveToPart(FormOfWorkWithDatabase form)
        {
            int selectedCalculation = form.Calculation.SelectedIndex;
            saveTechnologicalProcessInPart();
            saveSurfaceInPart(form);

            Part.insertParametersOfPartInTextboxes(form.parrentForm);
            Part.insertListOfTechnologicalProcessInTreeView(form.parrentForm);
        }

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

        private static void selectTechnologicalProcess(int index, FormOfWorkWithDatabase form)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            DependenceCalculation calculation = calculations[index];

            dbConnection.GetDataUsingDataAdapter($@"SELECT * FROM Operations WHERE ID_calculation = {calculation.getId()}", ref tempDataTable, ref tableDataAdapter);
            try
            {
                int countRows = tempDataTable.Rows.Count;

                workpriece = createWorkpriece(tempDataTable.Rows[0]);

                technologicalProcess = new List<DependenceOperationInTechnologicalProcess>();

                for(int i = 1; i < countRows; i++)
                {
                    DataRow row = tempDataTable.Rows[i];
                    technologicalProcess.Add(createOperation(row));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private static void getTechnologicalProcessInTreeView(FormOfWorkWithDatabase form)
        {
            TreeNodeCollection nodes = form.TechnologicalProcess.Nodes;

            nodes.Clear();

            nodes.Add(workpriece.getNameWorkpriece());

            foreach(DependenceOperationInTechnologicalProcess operation in technologicalProcess)
            {
                string nameOperation = operation.getOperation().getTypeOfMachining();
                nodes.Add(nameOperation);
            }
        }

       private static void selectSurfaceInDB(FormOfWorkWithDatabase form, int index)
       {
           DataTable tablesDataTable = new DataTable();
           DataTable tempDataTable = new DataTable();

           DependenceCalculation calculation = calculations[index];

           dbConnection.GetDataUsingDataAdapter($@"SELECT * FROM surface WHERE idCalculation = {calculation.getId()}", ref tempDataTable, ref tableDataAdapter);

           surfaces = new List<DependenceSurface>();

           try
           {
               foreach (DataRow row in tempDataTable.Rows)
               {
                    surfaces.Add(createSurface(row, form));
               }
           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
           }
       }

        private static void selectOperationInDB(int index)
        {
            DataTable tablesDataTable = new DataTable();
            DataTable tempDataTable = new DataTable();

            DependenceSurface surface = surfaces[index];

            dbConnection.GetDataUsingDataAdapter($@"SELECT * FROM operations_and_Results WHERE ID_surface = {surface.getIdInDb()}", ref tempDataTable, ref tableDataAdapter);

            operations = new List<DependenceOperation>();
            try
            {
                foreach (DataRow row in tempDataTable.Rows)
                {
                    int idOnTechnologicalProcess = Convert.ToInt32(row[0]);
                    int numberOperation = Convert.ToInt32(row[2]);
                    string typeOfInstrument = Convert.ToString(row[3]);

                    DependenceOperation operation = new DependenceOperation(idOnTechnologicalProcess, numberOperation, typeOfInstrument);
                    operations.Add(operation);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static void insertParametersIntextBox(FormOfWorkWithDatabase form, int index)
        {
            DependenceSurface surface = surfaces[index];
            ParametersOfSurface parameters = surface.getParametersOfSurface();

            form.diameterOfSurface.Text = parameters.getDiameterOfPart().ToString();

            form.typeOfPart.Text = parameters.getTypeOfPart().getName();
            form.typeOfAllowance.Text = parameters.getTypeOfAllowance().getName();
            form.TypeOfProcessedSurface.Text = parameters.getTypeOfProcessedSurface().getName();

            form.SurfaceRoughness.Text = parameters.getSurfaceRoughness().ToString();
            form.HoleDepth.Text = parameters.getHoleDepth().ToString();
            form.Tolerance.Text = parameters.getAllowance().ToString();
        }

        private static void insertOperationsInTreeView(FormOfWorkWithDatabase form)
        {
            defineDependenciesOperations();

            form.Operations.Nodes.Clear();

            foreach(DependenceOperation operation in operations)
            {
                string typeOfMachining = operation.getOperation().getTypeOfMachining();
                string typeOfInstrument = operation.getOperation().getTypeOfInstrument();

                form.Operations.Nodes.Add(typeOfMachining + ' ' + typeOfInstrument);
            }
        }

        private static DependenceOperationInTechnologicalProcess createOperation(DataRow row)
        {
            int idInDb = Convert.ToInt32(row[0]);

            int idOnTechnologicalProcess = Convert.ToInt32(row[1]);
            int idOperation = Convert.ToInt32(row[2]);
            string typeOfMachining = Convert.ToString(row[3]);

            DependenceOperationInTechnologicalProcess operation = new DependenceOperationInTechnologicalProcess(idInDb, typeOfMachining, idOperation, idOnTechnologicalProcess);

            return operation;
        }

        private static DependenceWorkpriece createWorkpriece(DataRow row)
        {
            int idInDb = Convert.ToInt32(row[0]);

            int idWorkpriece = Convert.ToInt32(row[2]);
            string nameWorkpriece = Convert.ToString(row[3]);

            return new DependenceWorkpriece(idInDb, nameWorkpriece, idWorkpriece);
        }

        private static DependenceSurface createSurface(DataRow row, FormOfWorkWithDatabase form)
        {
            int idInDb = Convert.ToInt32(row[0]);

            string nameSurface = Convert.ToString(row[2]);
            double diameter = Convert.ToDouble(row[3]);

            int typeIndex = Convert.ToInt32(row[4]);
            ComboBox comboBox = form.parrentForm.TypeOfPart;
            TypeOfPart typeOfPart = selectIndexOfTypesFromComboBox(typeIndex, comboBox);

            typeIndex = Convert.ToInt32(row[5]);
            comboBox = form.parrentForm.TypeOfAllowance;
            TypeOfPart typeOfAllowance = selectIndexOfTypesFromComboBox(typeIndex, comboBox);

            typeIndex = Convert.ToInt32(row[6]);
            comboBox = form.parrentForm.TypeOfProcessedSurface;
            TypeOfPart typeOfProcessedSurface = selectIndexOfTypesFromComboBox(typeIndex, comboBox);

            double surfaceRoughness = Convert.ToDouble(row[7]);
            double holeDepth = Convert.ToDouble(row[8]);
            double tolerance = Convert.ToDouble(row[9]);

            DependenceSurface surface = new DependenceSurface(idInDb, nameSurface, diameter, typeOfPart, typeOfAllowance, typeOfProcessedSurface, surfaceRoughness, tolerance, holeDepth);

            return surface;
        }

        private static void defineDependenciesOperations()
        {
            foreach (DependenceOperation operation in operations)
            {
                foreach (DependenceOperationInTechnologicalProcess dependenceoperationInTechnologicalProcess in technologicalProcess)
                {
                    Operation operationInTechnologicalProcess = dependenceoperationInTechnologicalProcess.getOperation();

                    if (operation.getIdOnTechnologicalProcess() == dependenceoperationInTechnologicalProcess.getIdInDb())
                    {
                        operation.setOperationInTechnologicalProcess(operationInTechnologicalProcess);
                    }
                }
            }
        }

        private static TypeOfPart selectIndexOfTypesFromComboBox(int typeIndex, ComboBox comboBox)
        {
            string namePart = "Некорректный тип";

            try
            {
                namePart = comboBox.Items[typeIndex].ToString();    
            }
            catch { }

            return new TypeOfPart(namePart, typeIndex);
        }

        private static void saveTechnologicalProcessInPart()
        {
            Part.getSurfaceOnIndex(0).getOperations().Clear();
            List<Operation> listOperation = Part.getSurfaceOnIndex(0).getOperations();

            foreach(DependenceOperationInTechnologicalProcess operations in technologicalProcess)
            {
                listOperation.Add(operations.getOperation());
            }
        }

        private static void saveSurfaceInPart(FormOfWorkWithDatabase form)
        {
            int countSurface = surfaces.Count;
            int selectIndexPart = form.Part.SelectedIndex;

            double lengtPart = parts[selectIndexPart].getLengthPart();

            for(int i = 1; i < countSurface; i++)
            {
                surfaces[i].getParametersOfSurface().setLengthOfPart(lengtPart);
                Part.setParametersOfPart(surfaces[i].getParametersOfSurface());

                saveOperationsInSurface(i);
            }
;       }

        private static void saveOperationsInSurface(int index)
        {
            selectOperationInDB(index);
            defineDependenciesOperations();

            List<Operation> operations = Part.getSurfaceOnIndex(index).getOperations();
            operations.Clear();

            foreach (DependenceOperation operation in EventOutputDataFromDataBase.operations)
            {
                operations.Add(new Operation(operation.getOperation()));
            }
        }
    }
}
