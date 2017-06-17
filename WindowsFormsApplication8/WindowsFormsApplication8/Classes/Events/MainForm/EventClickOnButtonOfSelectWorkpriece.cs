﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

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
            form.TreeOfSelectedOperations.Enabled = true;            
            form.TypeOfMachining.Enabled = true;
            form.ChoiceOfOperation.Enabled = true;
            form.Backspace.Enabled = true;
            form.CalculationOfSchema.Enabled = true;
            form.TypeOfInstrument.Enabled = true;
            form.LabelWorkpiece.Visible = true;
            form.NameOfWorkpiece.Visible = true;
            form.LabelTypeOfMachining.Visible = true;
            form.TypeOfMachining.Visible = true;
            form.LabelTypeOfInstrument.Visible = true;
            form.TypeOfInstrument.Visible = true;
            form.ChoiceOfOperation.Visible = true;
            form.Backspace.Visible = true;
            form.SaveChanges.Visible = true;
            form.TreeOfOperations.Visible = true;
            form.labelOperationsOrTechProcess.Visible = true;
            form.labelOfSelectedOperations.Visible = true;
            form.TreeOfSelectedOperations.Visible = true;
            form.SelectTechnologicalProcess.Visible = true;
            form.Size = new Size(922, 495);
            form.ChoiceOfWorkpiece.Size = new Size(437, 46);
            form.ChoiceOfWorkpiece.Location = new Point(465, 28);
        }

        public static void insertNameOfWorkpieceInTreeViewAndTextBox(MainForm form, string nameOfWorkpiece)
        {
            if(form.TreeOfSelectedOperations.Nodes.Count == 0)
            {
                form.TreeOfSelectedOperations.Nodes.Add(nameOfWorkpiece);
            }
            else
            {
                form.TreeOfSelectedOperations.Nodes[0].Text = nameOfWorkpiece;
            }
            form.NameOfWorkpiece.Text = nameOfWorkpiece;
        }
    }
}
