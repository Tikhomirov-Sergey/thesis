using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication8;
using System.Drawing;

namespace WindowsFormsApplication8
{
    class EventOutputDataFromDataBase
    {
        private static DBConnection dbConnection = DBConnection.getDB();
        private static SqlDataAdapter tableDataAdapter = new SqlDataAdapter();

        private static List<DependencePart> parts;
        private static List<DependencePart> searchPart;

        private static List<DependenceCalculation> calculations;

        private static DependenceWorkpriece workpriece;
        private static List<DependenceOperationInTechnologicalProcess> technologicalProcess;
        private static List<DependenceSurface> surfaces;
        private static List<DependenceOperation> operations;


        public static void getListNamesAndCipherPartsInComboBox(FormOfWorkWithDatabase form)
        {
            selectPartsInDB();
            searchPart = parts;

            form.NamePart.Items.Clear();
            form.CipherPart.Items.Clear();

            foreach (DependencePart part in searchPart)
            {
                form.NamePart.Items.Add(part.getName());
                form.CipherPart.Items.Add(part.getId());
            }

            try
            {
                form.NamePart.SelectedIndex = 0;
            }
            catch { }
        }

        public static void selectedIndexNamePartChanged(FormOfWorkWithDatabase form)
        {
            int selectIndexNamePart = form.NamePart.SelectedIndex;
            int selectIndexCipherPart = form.CipherPart.SelectedIndex;

            if (selectIndexNamePart != selectIndexCipherPart)
            {
                form.CipherPart.SelectedIndex = selectIndexNamePart;
            }

            form.LengthPart.Text = searchPart[selectIndexNamePart].getLengthPart().ToString();

            selectCalculationInDB(selectIndexNamePart);

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

        public static void selectedIndexCipherPartChange(FormOfWorkWithDatabase form)
        {
            int selectIndexCipherPart = form.CipherPart.SelectedIndex;
            int selectIndexNamePart = form.NamePart.SelectedIndex;
            
            if (selectIndexCipherPart != selectIndexNamePart)
            {
                form.NamePart.SelectedIndex = selectIndexCipherPart;
            }
        }

        public static void TextChangedInComboBoxNamePart(FormOfWorkWithDatabase form)
        {
            try
            {
                List<DependencePart> serchInPart = new List<DependencePart>();
                string serchString = form.NamePart.SelectedText;

                foreach (DependencePart part in parts)
                {
                    if (part.getName().StartsWith(serchString))
                    {
                        serchInPart.Add(part);
                    }
                }

                form.NamePart.Items.Clear();

                foreach (DependencePart part in serchInPart)
                {
                    form.NamePart.Items.Add(part.getName());
                }

                form.NamePart.SelectedIndex = 0;
                form.NamePart.DroppedDown = true;
            }
            catch { }
        }

        public static void selectedIndexComboBoxCalculationChange(FormOfWorkWithDatabase form)
        {
            int selectedIndex = form.Calculation.SelectedIndex;

            selectTechnologicalProcess(selectedIndex, form);
            getTechnologicalProcessInTreeView(form);

            getSurfacesInComboBoxAndTextBoxes(form, selectedIndex);
        }

        public static void selectedIndexComboBoxSurfaceChange(FormOfWorkWithDatabase form)
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
            saveWorkpriece();
            saveTechnologicalProcessInPart();
            saveSurfaceInPart(form);

            insertPartInMainForm(form);

            form.Close();
        }

        public static void searchByName(FormOfWorkWithDatabase form)
        {
           string searchString = form.SearchByName.Text;

           form.SearchByCipher.Text = "";

           searchPart = new List<DependencePart>();

           foreach(DependencePart part in parts)
           {
                if(part.getName().ToLower().StartsWith(searchString.ToLower()))
                {
                   searchPart.Add(part);
                }
           }

           form.NamePart.Items.Clear();
           form.CipherPart.Items.Clear();

           foreach (DependencePart part in searchPart)
           {
                form.NamePart.Items.Add(part.getName());
                form.CipherPart.Items.Add(part.getId());
           }

           try
           {
               if(form.NamePart.Items.Count != 0)
               {
                   form.NamePart.SelectedIndex = 0;
               }
               else
               {
                    clearForm(form);
               }    
           }
           catch { }
            
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

            DependencePart part = searchPart[index];

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

            form.SurfaceRoughness.Text = parameters.getSurfaceRoughnessRz().ToString();
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
                    Operation operationInTechnologicalProcess = new Operation(dependenceoperationInTechnologicalProcess.getOperation());

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
            int selectIndexPart = form.NamePart.SelectedIndex;

            double lengtPart = parts[selectIndexPart].getLengthPart();

            for(int i = 0; i < countSurface; i++)
            {
                int numberSurfaceInPart = i + 1;
                DependenceSurface surface = surfaces[i];

                surface.getParametersOfSurface().setLengthOfPart(lengtPart);

                Part.getSurfaceOnIndex(numberSurfaceInPart).setNameSurface(surface.getNameSurface());
                Part.setParametersOfPart(surfaces[i].getParametersOfSurface());

                saveOperationsInSurface(i);
            }
;       }

        private static void saveOperationsInSurface(int index)
        {
            int numberOperationInPart = index + 1;

            selectOperationInDB(index);
            defineDependenciesOperations();

            List<Operation> operations = Part.getSurfaceOnIndex(numberOperationInPart).getOperations();
            operations.Clear();

            foreach (DependenceOperation operation in EventOutputDataFromDataBase.operations)
            {
                Part.getSurfaceOnIndex(numberOperationInPart).setOpetation(new Operation(operation.getOperation()));
            }
        }

        private static void saveWorkpriece()
        {
            ParametersWorkpiece workpriece = Tables.getParametersOfWorkpieces().getParametersWorkprieceOnIndex(EventOutputDataFromDataBase.workpriece.getIdWorkpriece());
            Part.setWorkpiece(workpriece);
        }

        private static void insertPartInMainForm(FormOfWorkWithDatabase form)
        {
            Part.insertListOfSurfacess(form.parrentForm);
            Part.insertParametersOfPartInTextboxes(form.parrentForm);
            Part.insertListOfOperationsInTreeView(form.parrentForm);

            EventClickOnButtonOfSelectWorkpriece.enabledTextBoxes(form.parrentForm);

            form.parrentForm.SurfacesTreeView.SelectedNode = form.parrentForm.SurfacesTreeView.Nodes[0];
        }

        private static void clearForm(FormOfWorkWithDatabase form)
        {
            form.NamePart.Text = "";
            form.CipherPart.Text = "";

            form.Calculation.Items.Clear();
            form.Calculation.Text = "";

            form.Surfaces.Text = "";
            form.Surfaces.Items.Clear();

            form.TechnologicalProcess.Nodes.Clear();
            form.Operations.Nodes.Clear();

            form.LengthPart.Text = "";
            form.diameterOfSurface.Text = "";
            form.typeOfPart.Text = "";
            form.typeOfAllowance.Text = "";
            form.TypeOfProcessedSurface.Text = "";
            form.HoleDepth.Text = "";
            form.SurfaceRoughness.Text = "";
            form.Tolerance.Text = "";
        }
    }
}
