using System;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSaveToDatabase
    {
        private static DBConnection dbConnection = DBConnection.getDB();
        private static SqlDataAdapter tableDataAdapter = new SqlDataAdapter();
        private static SqlDataAdapter tempDataAdapter = new SqlDataAdapter();
        private static DataTable tempDataTable = new DataTable();

        const string
            DETAIL = "detail",
            CALCULATION = "calculation",
            TECHNOLOGICAL_PROCESS = "operations",
            SURFACE = "surface",
            OPERATIONS_AND_RESULTS = "operations_and_results";

        public static void buttonSaveToDatabase(Form5 form)
        {
         try
         {
             if (checkNameOfPartAndNameOfSurface(form))
             {
                    saveToDatabase(form);
                    MessageBox.Show("Сохранение прошло успешно");
                    form.Close();
             }
         }
            catch { MessageBox.Show("Ошибка Базы данных", "Ошибка"); }
        }

        private static bool checkNameOfPartAndNameOfSurface(Form5 form)
        {
            if (form.textBox1.Text.Equals(""))
            {
                MessageBox.Show("Введите наименование детали", "Ошибка");
                return false;
            }

            if (form.textBox2.Text.Equals(""))
            {
                MessageBox.Show("Введите обозначение поверхности", "Ошибка");
                return false;
            }

            return true;
        }

        private static void saveToDatabase(Form5 form)
        {
            DateTime date = DateTime.Now;
            string dateToString = date.ToString("MM.dd.yyyy");

            int cipherDetail = saveToTableOfPart(form, dateToString);
            int idCalculation = saveToCalculation(form, cipherDetail, dateToString);
            saveToTableTechnologicalProcessAndSurfaces(form, cipherDetail, idCalculation);
        }

        private static int saveToTableOfPart(Form5 form, string date)
        {
            string nameOfPart = form.textBox1.Text;
            int cipherDetail = Convert.ToInt32(form.textBox2.Text);

            bool isCipherExist = false;

            try
            {
                dbConnection.GetDataUsingDataAdapter($@"SELECT * FROM {DETAIL} WHERE cipher_detail = {cipherDetail}", ref tempDataTable, ref tableDataAdapter);

                isCipherExist = tempDataTable.Rows[0] != null;
            }

            catch { isCipherExist = false; }

            if (!isCipherExist)
            {
                ParametersOfSurface parametersOfPart = Part.getParametersOfPart();
                double lengthOfPart =  parametersOfPart.getLengthOfPart();

                dbConnection.SetQuery($@"INSERT INTO {DETAIL} VALUES ('{nameOfPart}', {cipherDetail}, '{date}', {doubleToStringForDb(lengthOfPart)})");
            }

            return cipherDetail;
        }

       private static int saveToCalculation(Form5 form, int cipherDetail, string date)
        {
           dbConnection.SetQuery($@"INSERT INTO {CALCULATION} VALUES ({cipherDetail}, '{date}')");

           return getIdentCurrent(CALCULATION); 
        }

        private static void saveToTableTechnologicalProcessAndSurfaces(Form5 form, int cipherDetail, int idCalculation)
        {
            ParametersWorkpiece workpiece = Part.getWorkpiece();
            int idWorkpieceInDB = saveWorkpiece(cipherDetail, idCalculation, workpiece);

            List<Operation> technologicalProcess = Part.getSurfaceOnIndex(0).getOperations();
            int countOperation = Part.getSurfaceOnIndex(0).getCountShortListOperation();

            for(int i = 0; i < countOperation; i++)
            {
               int idOperation = saveOperationInTechnologicalProcess(cipherDetail, idCalculation, technologicalProcess[i], i + 1);
            }

            saveSurfaces(cipherDetail, idCalculation);
        }

        private static int saveWorkpiece(int cipherDetail, int idCalculation, ParametersWorkpiece workpiece)
        {
            int idOperation = workpiece.getIdWorkpieceInTable();
            string nameOperation = workpiece.getNameOfWorkpiece();

            dbConnection.SetQuery($@"INSERT INTO {TECHNOLOGICAL_PROCESS} VALUES ({0}, {idOperation}, '{nameOperation}', {cipherDetail}, {idCalculation})");
            
           
            return getIdentCurrent(TECHNOLOGICAL_PROCESS);
        }

        private static int saveOperationInTechnologicalProcess(int cipherDetail, int idCalculation, Operation technologicalProcess, int numberOperation)
        {
            int idOperation = technologicalProcess.getIdOperation();
            string nameOperation = technologicalProcess.getTypeOfMachining();

            dbConnection.SetQuery($@"INSERT INTO {TECHNOLOGICAL_PROCESS} VALUES ({numberOperation}, {idOperation}, '{nameOperation}', {cipherDetail}, {idCalculation})");

            return getIdentCurrent(TECHNOLOGICAL_PROCESS);
        }

        private static void saveSurfaces(int cipherDetail, int idCalculation)
        {
            List<Surface> surfaces = Part.getSurfaces();
            int countSufaces = Part.getCountSurfaces();

            for (int i = 1; i < countSufaces; i++)
            {
                Surface surface = surfaces[i];
                ParametersOfSurface parametersOfSurface = Part.getParametersOfPart();

                string nameSurface = surface.getNameSurface();

                double diameterOfSurface = parametersOfSurface.getDiameterOfPart();

                int typeOfPart = parametersOfSurface.getTypeOfPart().getIndex();
                int typeOfAllowance = parametersOfSurface.getTypeOfAllowance().getIndex();
                int typeOfProcessedSurface = parametersOfSurface.getTypeOfProcessedSurface().getIndex();

                double surfaseRoughness = parametersOfSurface.getSurfaceRoughness();
               
                double holeDepth = parametersOfSurface.getHoleDepth();
                double tolerance = parametersOfSurface.getAllowance();
                
                dbConnection.SetQuery($@"INSERT INTO {SURFACE} VALUES ({idCalculation}, '{nameSurface}', {doubleToStringForDb(diameterOfSurface)}, {typeOfPart}, {typeOfAllowance}, {typeOfProcessedSurface}, {doubleToStringForDb(surfaseRoughness)}, {doubleToStringForDb(holeDepth)}, {doubleToStringForDb(tolerance)})");
                   
                int idSurface = getIdentCurrent(SURFACE);

                saveToTableOperationsAndResults(idSurface, surface, idCalculation);
            }
        }

        private static void saveToTableOperationsAndResults(int idSurface, Surface surface, int idCalculation)
        {
            List<Operation> operation = surface.getOperations();
            int countOperations = surface.getCountShortListOperation();

            for(int i = 0; i < countOperations; i++)
            {
                int idOnTechnologicalProcess = operation[i].getIdOnTechnologicalProcess();
                string typeOfInstrument = operation[i].getTypeOfInstrument();

                dbConnection.GetDataUsingDataAdapter($@"SELECT ID FROM {TECHNOLOGICAL_PROCESS} WHERE ID_calculation = {idCalculation} AND Number_operation = {idOnTechnologicalProcess + 1}", ref tempDataTable, ref tableDataAdapter);

                idOnTechnologicalProcess = Convert.ToInt32(tempDataTable.Rows[0][0]);

                dbConnection.SetQuery($@"INSERT INTO {OPERATIONS_AND_RESULTS} VALUES ({idOnTechnologicalProcess}, {idSurface}, {i + 1}, '{typeOfInstrument}')");
            }
        }

        private static int getIdentCurrent(string nameTable)
        {
            dbConnection.GetDataUsingDataAdapter($@"SELECT IDENT_CURRENT('{nameTable}')", ref tempDataTable, ref tableDataAdapter);
            return Convert.ToInt32(tempDataTable.Rows[0][0]);
        }

        private static string doubleToStringForDb(double value)
        {
            return value.ToString().Replace(',', '.');
        }








       private static void saveToTableOfOperations(Form5 form, int index)
        {
           Surface surface = Part.getSurfaceOnIndex(0);

            List<ParametersOperation> parametersOperations = surface.getParametersOperation();

            int numberOfOperation = surface.getCountLongListOperation();

            for (int i = 0; i < numberOfOperation; i++)
            {
                ParametersOperation parametersOperation = parametersOperations[i];

                ClassesToCalculate.ResultsOfCalculation resultsOfCalculation = parametersOperation.getResultsOfCalculation();

                string nameOperation = parametersOperation.getTypeOfMachining() + ',' + parametersOperation.getPrecisionOfMachining();

              //  form.переходыTableAdapter.Insert(Convert.ToInt16(form.dataGridView1[0, index - 1].Value.ToString()) + 1, i + 1, nameOperation, parametersOperation.getTypeOfInstrument(), (float)parametersOperation.getSurfaceRoughnessRz(), (float)parametersOperation.getThicknessOfDefectiveCoating(), (float)resultsOfCalculation.getSpatialDeviation(), (float)resultsOfCalculation.getdeviationOfInstallation(), (float)resultsOfCalculation.getAccuracies(), (float)resultsOfCalculation.getNominalAllowance(), (float)resultsOfCalculation.getSizeOfWorkprieceAfterOperation(), parametersOperation.getIdOperation(), null, (float)parametersOperation.getCoefficientOfRefinement(), (int)parametersOperation.getKvalitet());
            }
        }

        private static void saveWorkpieceToTableOfOperations(Form5 form, int index)
        {
            ParametersWorkpiece parametersWorkpiece = Part.getWorkpiece();
            
           // ClassesToCalculate.ResultsOfCalculation resultOfCalculation = Part.getSurfaceOnIndex(0).getResultsOfCalculation();

           // form.переходыTableAdapter.Insert(Convert.ToInt16(form.dataGridView1[0, index - 1].Value.ToString()) + 1, 0, parametersWorkpiece.getNameOfWorkpiece(), "", (float)parametersWorkpiece.getSurfaceRoughnessRz(), (float)parametersWorkpiece.getThicknessOfDefectiveCoating(), (float)resultOfCalculation.getSpatialDeviation()[0], (float)resultOfCalculation.getdeviationOfInstallation()[0], (float)resultOfCalculation.getAccuracies()[0], (float)resultOfCalculation.getNominalAllowance()[0], (float)resultOfCalculation.getSizeOfWorkprieceAfterOperation()[0], parametersWorkpiece.getIdWorkpiece(), null, (float)parametersWorkpiece.getValidOffsetSurface(), (int)parametersWorkpiece.getKvalitet());
        }
    }
}
