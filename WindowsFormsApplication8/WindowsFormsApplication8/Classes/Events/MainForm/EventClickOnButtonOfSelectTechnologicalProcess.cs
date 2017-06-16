﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication8
{
    class EventClickOnButtonOfSelectTechnologicalProcess
    {
        public static void buttonSelectProcess(MainForm form)
        {
            string nameSurface = "Поверхность 1";
            int countNodes = form.SurfacesTreeView.Nodes.Count;

            distributionIdOnTechnologicalProcess(Part.getSurfaceOnIndex(0).getOperations());

            if (countNodes == 1)
            {
                form.SurfacesTreeView.Nodes.Add("notChange", nameSurface);

                Part.setNameSurfaceOnIndex(1, nameSurface);
                Part.copyTechnologicalProcessInSurface(1);
            }

            StorageOfSelectedOperation.setIndexSelectedSurface(1);
            form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[1];

            form.NameSurface.Text = nameSurface;
            
            Part.insertListOfOperationsInTreeView(form, 1);
            Part.insertListOfTechnologicalProcessInTreeView(form);

            form.Surfaces.Visible = true;
            form.NameSurface.Visible = true;
            form.SurfacesTreeView.Visible = true;
            form.addSurfaceButton.Visible = true;
            form.delSurfaceButton.Visible = true;

            form.TreeOfOperations.Size = new Size(401,168);
            form.TreeOfOperations.Location = new Point(12,389);

            form.labelOperationsOrTechProcess.Size = new Size(91,13);
            form.labelOperationsOrTechProcess.Location = new Point(169, 373);

            form.SelectTechnologicalProcess.Visible = false;
            form.labelOperationsOrTechProcess.Text = "Тех. процесс";
            enabledTextBoxes(form);
        }

        private static void enabledTextBoxes(MainForm form)
        {
            form.addSurfaceButton.Enabled = true;
            form.delSurfaceButton.Enabled = true;
            form.SurfacesTreeView.Enabled = true;
            form.CalculationOfSchema.Visible = true;

            form.LabelDiameterOfPart.Visible = true;
            form.DiameterOfPart.Visible = true;
            form.LabelTypeOfPart.Visible = true;
            form.TypeOfPart.Visible = true;
            form.LabelTypeOfAllowance.Visible = true;
            form.TypeOfAllowance.Visible = true;
            form.LabelTypeOfProcessedSurface.Visible = true;
            form.TypeOfProcessedSurface.Visible = true;
            form.LabelHoleDepth.Visible = true;
            form.HoleDepth.Visible = true;
            form.LabelAllowance.Visible = true;
            form.Allowance.Visible = true;
            form.LabelRoughness.Visible = true;
            form.SurfaceRoughness.Visible = true;
            form.pictureBox1.Visible = true;
            form.pictureBox2.Visible = true;

            form.LabelWorkpiece.Size = new Size(60, 13);
            form.LabelWorkpiece.Location = new Point(588, 37);

            form.NameOfWorkpiece.Size = new Size(424, 20);
            form.NameOfWorkpiece.Location = new Point(654, 34);

            form.ChoiceOfWorkpiece.Size = new Size(487, 55);
            form.ChoiceOfWorkpiece.Location = new Point(591, 60);

            form.TypeOfMachining.Size = new Size(234, 20);
            form.TypeOfMachining.Location = new Point(676,131);

            form.LabelTypeOfMachining.Size = new Size(82, 13);
            form.LabelTypeOfMachining.Location = new Point(588, 134);

            form.TypeOfInstrument.Size = new Size(203, 21);
            form.TypeOfInstrument.Location = new Point(707, 169);

            form.LabelTypeOfInstrument.Size = new Size(113, 13);
            form.LabelTypeOfInstrument.Location = new Point(588, 172);

            form.ChoiceOfOperation.Size = new Size(79, 78);
            form.ChoiceOfOperation.Location = new Point(916, 121);

            form.Backspace.Size = new Size(77, 35);
            form.Backspace.Location = new Point(1001, 121);

            form.SaveChanges.Size = new Size(77, 37);
            form.SaveChanges.Location = new Point(1001, 162);
        }

        private static void distributionIdOnTechnologicalProcess(List<Operation> technologicalProcess)
        {
            int countSurfaces = Part.getCountSurfaces();
            int count = technologicalProcess.Count;
            if (countSurfaces == 1)
            {
                for (int i = 0; i < count; i++)
                {
                    technologicalProcess[i].setIdOnTechnologicalProcess(i);
                }
            }
            else
            {
                checkIdOperationsInSurfaces();

                for (int i = 0; i < count; i++)
                {
                    changeIdOperationsInSurfaces(technologicalProcess[i], i);
                }
            }
        }

        private static void changeIdOperationsInSurfaces(Operation operationInTechnologicalProcess, int idOnTechnologicalProcessNew)
        {
            int countSurfaces = Part.getCountSurfaces();
            List<Surface> surfaces = Part.getSurfaces();

            int idOnTechnologicalProcessOld = operationInTechnologicalProcess.getIdOnTechnologicalProcess();
            operationInTechnologicalProcess.setIdOnTechnologicalProcess(idOnTechnologicalProcessNew);

            for (int i = 1; i < countSurfaces; i++)
            {
                Surface surface = surfaces[i];

                foreach(Operation operation in surface.getOperations())
                {
                    if(operation.getIdOnTechnologicalProcess() == idOnTechnologicalProcessOld)
                    {
                        operation.setIdOnTechnologicalProcess(idOnTechnologicalProcessNew);
                    }
                }
            }
        }

        private static void checkIdOperationsInSurfaces()
        {
            List<Surface> surfaces = Part.getSurfaces();
            int countSurfaces = Part.getCountSurfaces();

            for (int i = 1; i < countSurfaces; i++)
            {
                Surface surface = surfaces[i];

                int countOperation = surface.getCountShortListOperation();

                for (int g = 0; g < countOperation; g++)
                {
                    Operation operation = surface.getOperationOnIndex(g);

                    if (!includedInTechnologicalProcess(operation))
                    {
                        surface.deleteOperation(g);
                        g--;
                        countOperation--;
                    }
                }
            }
        }

        private static bool includedInTechnologicalProcess(Operation operation)
        {
            int idOperationOntechnologicalProcess = operation.getIdOnTechnologicalProcess();

            List<Operation> technologicalProcess = Part.getSurfaceOnIndex(0).getOperations();

            foreach (Operation operationInTechnologicalProcess in technologicalProcess)
            {
                if(idOperationOntechnologicalProcess == operationInTechnologicalProcess.getIdOnTechnologicalProcess())
                {
                    return true;
                }
            }

            return false;
        }        
    }
}
