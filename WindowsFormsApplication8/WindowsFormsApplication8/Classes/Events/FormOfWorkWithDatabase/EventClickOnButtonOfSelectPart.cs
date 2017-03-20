using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSelectPart
    {
        public static void buttonSelectPartInFormOfWorkWithDatabase(FormOfWorkWithDatabase form, MainForm parrentForm)
        {
            try
            {
                insertParametersOfPart(form, parrentForm);
                Part.insertParametersOfPartInTextboxes(parrentForm);

                insertParametersOfWorkpriece(form);
                Part.insertNameOfWorkpieceInTreeViewAndTextBox(parrentForm);

                insertParametersOfOperations(form);
                Part.insertListOfOperationsInTreeView(parrentForm);

                form.Close();
            }

            catch { MessageBox.Show("Выбранная запись поврежденна", "Ошибка"); }
        }

        private static void insertParametersOfPart(FormOfWorkWithDatabase form, MainForm parrentForm)
        {
            double lengthOfPart = Convert.ToDouble(form.dataGridView1.CurrentRow.Cells[3].Value.ToString());
            double diameterOfPart = Convert.ToDouble(form.dataGridView1.CurrentRow.Cells[4].Value.ToString());

            string typeOfPart = form.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            string typeOfAllowance = form.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            string typeOfProcessedSurface = form.dataGridView1.CurrentRow.Cells[9].Value.ToString();

            int indexOfTypeOfPart = selectIndexOfTypesFromComboBox(typeOfPart, parrentForm.TypeOfPart);
            int indexOfTypeOfAllowance = selectIndexOfTypesFromComboBox(typeOfAllowance, parrentForm.TypeOfAllowance);
            int indexOfTypeOfProcessedSurface = selectIndexOfTypesFromComboBox(typeOfProcessedSurface, parrentForm.TypeOfProcessedSurface);

            double allowance = Convert.ToDouble(form.dataGridView1.CurrentRow.Cells[5].Value.ToString());
            double holeDepth = Convert.ToDouble(form.dataGridView1.CurrentRow.Cells[7].Value.ToString());

            ParametersOfPart parametersOfPart = new ParametersOfPart(lengthOfPart, diameterOfPart, indexOfTypeOfPart, indexOfTypeOfAllowance, indexOfTypeOfProcessedSurface, allowance, holeDepth);
            Part.setParametersOfPart(parametersOfPart);
        }

        private static int selectIndexOfTypesFromComboBox(string type, ComboBox comboBox)
        {
            bool validType = false;
            int indexOfType = 0;

            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString().Equals(type))
                {
                    validType = true;
                    indexOfType = i;
                }
            }
            if (!validType)
            {
                throw new Exception();
            }

            return indexOfType;
        }

        private static void insertParametersOfWorkpriece(FormOfWorkWithDatabase form)
        {
            string nameOfWorkpiece = form.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            int idWorkpiece = Convert.ToInt32(form.dataGridView2[12, 0].Value.ToString());

            double surfaceRoughnessRz = Convert.ToDouble(form.dataGridView2[4, 0].Value.ToString());
            Interval recommendedIntervalRz = new Interval();

            int kvalitet = Convert.ToInt32(form.dataGridView2[14, 0].Value.ToString());
            double thicknessOfDefectiveCoating = Convert.ToDouble(form.dataGridView2[5, 0].Value.ToString());
            double validOffsetSurface = Convert.ToDouble(form.dataGridView2[13, 0].Value.ToString());

            ParametersWorkpiece parametersWorkpiece = new ParametersWorkpiece(nameOfWorkpiece, idWorkpiece, surfaceRoughnessRz, recommendedIntervalRz, kvalitet, thicknessOfDefectiveCoating, validOffsetSurface);
            Part.setWorkpiece(parametersWorkpiece);
        }

        private static void insertParametersOfOperations(FormOfWorkWithDatabase form)
        {
            int numberOfOperations = form.dataGridView2.Rows.Count - 1;
            Surface surface = new Surface();

            for (int i = 1; i < numberOfOperations; i++)
            {
                ParametersOperation parametersOperation = createOperation(form, i);
                surface.setOpetation(parametersOperation);
            }

            Part.setOpetations(surface, 0);
        }


        private static ParametersOperation createOperation(FormOfWorkWithDatabase form, int index)
        {
            string typeOfMachiningAndPrecisionOfMachining = form.dataGridView2[2, index].Value.ToString();
            string[] splitString = parseString(typeOfMachiningAndPrecisionOfMachining, ',');

            string typeOfMachining = splitString[0].Trim();
            string precisionOfMachining = splitString[1].Trim();

            double surfaceRoughnessRz = Convert.ToDouble(form.dataGridView2[4, index].Value.ToString()); ;
            Interval recommendedIntervalRz = new Interval();

            int idOperation = Convert.ToInt32(form.dataGridView2[12, index].Value.ToString());
            double kvalitet = Convert.ToInt32(form.dataGridView2[14, index].Value.ToString()); ;

            double thicknessOfDefectiveCoating = Convert.ToDouble(form.dataGridView2[5, index].Value.ToString());
            double coefficientOfRefinement = Convert.ToDouble(form.dataGridView2[13, index].Value.ToString()); ;
            string typeOfInstrument = form.dataGridView2[3, index].Value.ToString();

            ParametersOperation parametersOperation = new ParametersOperation(typeOfMachining, precisionOfMachining, surfaceRoughnessRz, recommendedIntervalRz, idOperation, kvalitet, thicknessOfDefectiveCoating, coefficientOfRefinement, typeOfInstrument);

            return parametersOperation;
        }

        private static string[] parseString(string str, char symbol)
        {
            string[] splitStr = str.Split(new Char[] { symbol });
            return splitStr;
        }
    }
}
