using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class Part
    {
        private static ParametersOfSurface parametersOfSurface = null;
        private static ParametersWorkpiece workpriece = null;
        private static double lenght;

        //surfaces[0] = technologicalProcess;
        private static List<Surface> surfaces = new List<Surface>();
        
        public static ParametersOfSurface getParametersOfPart()
        {
            return parametersOfSurface;
        }

        public static void setParametersOfPart(ParametersOfSurface parametersOfPart)
        {
            Part.parametersOfSurface = parametersOfPart;
        }

        public static double getLenghtOfPart()
        {
            return lenght;
        }

        public static void setLenghtOfPart(double lenght)
        {
            Part.lenght = lenght;
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
                checkSurface(indexOfSurface);
                return surfaces[indexOfSurface];
            }
            catch { return null; }
        }

        public static void setNameSurfaceOnIndex(int indexOfSurface, string nameSurface)
        {
            checkSurface(indexOfSurface);
            getSurfaceOnIndex(indexOfSurface).setNameSurface(nameSurface);
        }

        public static int getCountSurfaces()
        {
            return surfaces.Count;
        }

        public static void calculationOfSurfaces()
        {
          try
          {
                int count = surfaces.Count;

                for(int i = 1; i < count; i++)
                {
                    surfaces[i].calculationOFSurface();
                }
          }
         catch(Exception e) { }
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
            parametersOfSurface.insertParametersOfPartInTextboxes(form);
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

        public static void insertListOfTechnologicalProcessInTreeView(MainForm form)
        {
            try
            {
                List<Operation> technologicalProcess = getSurfaceOnIndex(0).getOperations();

                form.TreeOfOperations.Nodes.Clear();

                foreach(Operation operation in technologicalProcess)
                {
                    form.TreeOfOperations.Nodes.Add(operation.getTypeOfMachining());
                }
            }
            catch { }
        }

        public static void insertListOfSurfacess(MainForm form)
        {
            try
            {
                form.SurfacesTreeView.Nodes.Clear();

                foreach(Surface surface in surfaces)
                {
                    form.SurfacesTreeView.Nodes.Add(surface.getNameSurface());
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

        public static void copyTechnologicalProcessInSurface(int indexSurface)
        {
            try
            {
                List<Operation> technologicalProcess = surfaces[0].getOperations();

                List<Operation> operations = new List<Operation>();

                foreach (Operation operationInTechnologicalProcess in technologicalProcess)
                {
                    Operation operation = new Operation(operationInTechnologicalProcess);
                    operations.Add(operation);
                }

                getSurfaceOnIndex(indexSurface).setOpetation(operations);
            }
            catch { }
        }

        public static void deleteSurface(int indexOfSurface)
        {
            try
            {
                surfaces.RemoveAt(indexOfSurface);
            }
            catch { }
        }
    }
}
