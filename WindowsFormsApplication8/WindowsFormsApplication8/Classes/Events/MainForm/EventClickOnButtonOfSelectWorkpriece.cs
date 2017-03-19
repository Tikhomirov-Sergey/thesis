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

            if (workpiece != null)
            {
                string nameOfWorkpiece = workpiece.getNameOfWorkpiece();
                insertNameOfWorkpieceInTreeViewAndTextBox(form, nameOfWorkpiece);
                enabledTextBoxes(form);
            }
        }

        private static void openingOfFormOfSelectWorkpriece()
        {
            FormOfSelectWorkpiece form = new FormOfSelectWorkpiece();
            form.ShowDialog();
        }

        public static void enabledTextBoxes(MainForm form)
        {
            form.TreeOfOperations.Enabled = true;
            form.treeView1.Enabled = true;
            form.SurfaceRoughnessRz.Enabled = true;
            form.SurfaceRoughnessRa.Enabled = true;
            form.PrecisionOfMachining.Enabled = true;
            form.TypeOfMachining.Enabled = true;
            form.ChoiceOfOperation.Enabled = true;
            form.Backspace.Enabled = true;
            form.CalculationOfSchema.Enabled = true;
            form.TypeOfInstrument.Enabled = true;
        }

        private static void insertNameOfWorkpieceInTreeViewAndTextBox(MainForm form, string nameOfWorkpiece)
        {
            if(form.treeView1.Nodes.Count == 0)
            {
                form.treeView1.Nodes.Add(nameOfWorkpiece);
            }
            else
            {
                form.treeView1.Nodes[0].Text = nameOfWorkpiece;
            }
            form.NameOfWorkpiece.Text = nameOfWorkpiece;
        }
    }
}
