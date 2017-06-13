using System;
using System.Windows.Forms;
using System.Data.Linq;
using System.Linq;
using System.Collections.Generic;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSaveToDatabase
    {
        public static void buttonSaveToDatabase(Form5 form)
        {
         try
         {
                if (checkNameOfPartAndNameOfSurface(form))
                {
                    saveToDatabase(form);
                    MessageBox.Show("Сохранение прошло успешно", "Ошибка");
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

            int cipherDetail = saveToTableOfPart(form, date);
            int idCalculation = saveToCalculation(form, cipherDetail, date);
            saveToTableOperations(form, cipherDetail, idCalculation);


            //saveWorkpieceToTableOfOperations(form, index);
            //saveToTableOfOperations(form, index);
        }

        private static int saveToTableOfPart(Form5 form, DateTime date)
        {
            string nameOfPart = form.textBox1.Text;
            int cipherDetail = Convert.ToInt32(form.textBox2.Text);

            bool isCipherExist = false;

            try
            {
                string index = form.chainsDataSet1.Detail.Select("cipher_detail = " + cipherDetail)[0][0].ToString();
                isCipherExist = true;
            }

            catch { isCipherExist = false; }

            if (!isCipherExist)
            {
                ParametersOfSurface parametersOfPart = Part.getParametersOfPart();

                //form.детальTableAdapter1.Insert(nameOfPart, date, (float)parametersOfPart.getLengthOfPart(), (float)parametersOfPart.getDiameterOfPart(), parametersWorkpiece.getKvalitet(), (float)parametersWorkpiece.getSurfaceRoughnessRz(), (float)parametersWorkpiece.getThicknessOfDefectiveCoating(), parametersOfPart.getTypeOfPart().getName(), parametersOfPart.getTypeOfProcessedSurface().getName(), parametersOfPart.getTypeOfAllowance().getName(), parametersWorkpiece.getNameOfWorkpiece(), nameOfSurface);

                form.detailTableAdapter.Insert(nameOfPart, cipherDetail, date, (float)parametersOfPart.getLengthOfPart());
            }

            return cipherDetail;
        }

        private static int saveToCalculation(Form5 form, int cipherDetail, DateTime date)
        {
            int idCalculation = form.calculationTableAdapter.Insert(cipherDetail, date);
            return idCalculation;
        }

        private static void saveToTableOperations(Form5 form, int cipherDetail, int idCalculation)
        {
            List<Operation> technologicalProcess = Part.getSurfaceOnIndex(0).getOperations();

            int countOperations = Part.getSurfaceOnIndex(0).getCountShortListOperation();


            /* for(int i = 0; i < countOperations; i++)
             {
                 Operation operation = technologicalProcess[i];

                 form.operationsTableAdapter.Insert(i, operation.getIdOperation(), (float)i, cipherDetail, idCalculation, i+1);
             }*/
            form.operationsTableAdapter.Insert(1, 1, 2, 43, 1, 1);
            
           // form.surfaceTableAdapter.Insert(1, 43, 4, 4, 4, 4, 1, 1);

          for(int i = 0; i < countOperations; i++)
          {
             Operation operation = technologicalProcess[i];

             form.operationsTableAdapter.Insert(i, operation.getIdOperation(), 5, 43, i, i);
          }

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
