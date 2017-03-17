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

                form.Close();
            }
            catch { }
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

            for(int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString().Equals(type))
                {
                    validType = true;
                    indexOfType = i;
                }
            }
            if (!validType)
            {
                throw new ErrorMessage("Выбранная запись поврежденна");
            }

            return indexOfType;
        }
    }
}
