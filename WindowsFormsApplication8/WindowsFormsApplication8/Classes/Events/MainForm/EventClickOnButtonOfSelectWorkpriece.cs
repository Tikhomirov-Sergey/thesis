using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSelectWorkpriece
    {
        public static void buttonSelectWorkpriece(MainForm form)
        {
            openingOfFormOfSelectWorkpriece();
            ParametersWorkpiece workpiece = Part.getWorkpiece();
            form.NameOfWorkpiece.Text = workpiece.getNameOfWorkpiece();
            enabledTextBoxes(form);
        }

        private static void openingOfFormOfSelectWorkpriece()
        {
            FormOfSelectWorkpiece form = new FormOfSelectWorkpiece();
            form.ShowDialog();
        }

        private static void enabledTextBoxes(MainForm form)
        {
            form.TreeOfOperations.Enabled = true;
            form.richTextBox1.Enabled = true;
            form.SurfaceRoughnessRz.Enabled = true;
            form.SurfaceRoughnessRa.Enabled = true;
            form.PrecisionOfMachining.Enabled = true;
            form.TypeOfMachining.Enabled = true;
            form.ChoiceOfOperation.Enabled = true;
            form.Backspace.Enabled = true;
            form.CalculationOfSchema.Enabled = true;
            form.TypeOfInstrument.Enabled = true;
            form.richTextBox2.Enabled = true;
            form.buttontext.Enabled = true;
        }
    }
}
