using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class ClickOnSurfacesTreeView
    {
        public static void getSurfacesTreeView(FormResult form)
        {
            try
            {
                TreeNode Surface = new TreeNode();

                List<Surface> surfaces = Part.getSurfaces();

                int count = surfaces.Count;
                
                for( int i = 1; i <= count; i++ )
                {
                   form.SurfacesTreeView.Nodes.Add(surfaces[i].getNameSurface());
                }
                
            }
            catch { MessageBox.Show("buttonAddSurface"); }
        }
        public static void clickOnNode(TreeNodeMouseClickEventArgs e, FormResult form)
        {
            int index = e.Node.Index + 1;

            insertOperationsOnReachBox(form, index);
        }

        public static void clickOnNode(int index, FormResult form)
        {
            insertOperationsOnReachBox(form, index);
        }

        private static void insertOperationsOnReachBox(FormResult form, int index)
        {
            int typeOfPart = Part.getParametersOfPart().getTypeOfPart().getIndex();
            char type;

            if (typeOfPart == 0)
            {
                type = '-';
            }
            else
            {
                type = '+';
            }

            ClassesToCalculate.ResultsOfCalculation resultWorkpiece = Part.getWorkpiece().getResultsOfCalculation();


            form.richTextBoxResult.Text = "Исходные данные: " + Part.getWorkpiece().getNameOfWorkpiece() + "\nСоставляющая припуска P= " + resultWorkpiece.getSpatialDeviation().ToString() + "\nРазмер= " + resultWorkpiece.getSizeOfWorkprieceAfterOperation().ToString() + "(" + type + Part.getWorkpiece().getResultsOfCalculation().getAccuracies() + ")";

            for (int i = 0; i < Part.getSurfaceOnIndex(index).getCountLongListOperation(); i++)
            {
                resultWorkpiece = Part.getSurfaceOnIndex(index).getParametersOperation()[i].getResultsOfCalculation();

                form.richTextBoxResult.Text += "\n" + i.ToString() + ") ";
                form.richTextBoxResult.Text += Part.getSurfaceOnIndex(index).getParametersOperation()[i].getNameOperation();
                form.richTextBoxResult.Text += "\nСоставляющая припуска E= " + resultWorkpiece.getdeviationOfInstallation().ToString() + "\nСоставляющая припуска P= " + resultWorkpiece.getSpatialDeviation().ToString() + "\nВеличина номинального припуска Znom= " + resultWorkpiece.getNominalAllowance().ToString() + "\nРазмер= " + resultWorkpiece.getSizeOfWorkprieceAfterOperation().ToString() + "(" + type + resultWorkpiece.getAccuracies() + ")";
            }
        }
    }
}

