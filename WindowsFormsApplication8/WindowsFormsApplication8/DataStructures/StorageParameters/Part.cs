﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class Part
    {
        private static ParametersOfPart parametersOfPart = null;
        private static ParametersWorkpiece workpriece = null;
        private static List<Surface> surfaces = new List<Surface>();

        
        public static ParametersOfPart getParametersOfPart()
        {
            return parametersOfPart;
        }

        public static void setParametersOfPart(ParametersOfPart parametersOfPart)
        {
            Part.parametersOfPart = parametersOfPart;
        }

        public static ParametersWorkpiece getWorkpiece()
        {
            return workpriece;
        }

        public static void setWorkpiece(ParametersWorkpiece workpirece)
        {
            Part.workpriece = workpirece;
        }

        public static void setOpetations(Surface operations)
        {
            surfaces.Add(operations);
        }

        public static void setOpetations(Surface operations, int index)
        {
            if (!surfaceIsNull(index))
            {
                surfaces[index] = operations;
            }
            else
            {
                surfaces.Insert(index, operations);
            }
            
        }

        public static List<Surface> getSurfaces()
        {
            return surfaces;
        }

        public static void addOperationInSurface(Operation operation, int indexSurface, int indexOfOperation)
        {
            try
            {
                checkSurface(indexSurface);
                surfaces[indexSurface].setOpetation(operation, indexOfOperation);
            }
            catch { }
        }

        public static Surface getSurfaceOnIndex(int indexOfSurface)
        {
            try
            { 
                return surfaces[indexOfSurface];
            }
            catch { return null; }
        }

        public static void calculationOfSurfaces()
        {
            foreach (Surface surface in Part.surfaces)
            {
                surface.calculationOFSurface();
            }
        }

        private static void checkSurface(int indexSurface)
        {
            try
            {
                if (surfaceIsNull(indexSurface))
                {
                    surfaces.Insert(indexSurface, new Surface());
                }
            }
            catch { }
        }

        private static bool surfaceIsNull(int indexSurface)
        {
            return (surfaces.Count - 1 < indexSurface);
        }

        public static void insertParametersOfPartInTextboxes(MainForm form)
        {
            parametersOfPart.insertParametersOfPartInTextboxes(form);
        }

        public static void insertNameOfWorkpieceInTreeViewAndTextBox(MainForm form)
        {
            workpriece.insertNameOfWorkpieceInTreeViewAndTextBox(form);
        }

        public static void insertListOfOperationsInTreeView(MainForm form, int indexOfSurface = 0)
        {
            try
            {
                insertNameOfWorkpieceInTreeViewAndTextBox(form);

                if (surfaces[indexOfSurface] != null)
                {
                    surfaces[indexOfSurface].insertListOfOperationsInTreeView(form);
                }
                else
                {
                    surfaces[0].insertListOfOperationsInTreeView(form);
                }
            }
            catch { } 
        }
        
        public static void deleteOperation(int indexOfSurface, int indexOfOperation)
        {
            try
            {
                getSurfaceOnIndex(indexOfSurface).deleteOperation(indexOfOperation);
            }
            catch { }
        }
    }
}
