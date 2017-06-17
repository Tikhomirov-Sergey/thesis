using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication8
{
    class EventClickOfMouseOnSurfacesTreeView
    {
        public static void clickOnNode(TreeNodeMouseClickEventArgs e, MainForm form)
        {
            int selectedIndex = e.Node.Index;

            StorageOfSelectedOperation.setIndexSelectedSurface(selectedIndex);
            form.NameSurface.Text = Part.getSurfaceOnIndex(selectedIndex).getNameSurface();

            if (selectedIndex == 0)
            {
                StorageOfSelectedOperation.setIndexSelectedSurface(0);
                form.SurfacesTreeView.SelectedNode = form.SurfacesTreeView.Nodes[0];
                Part.insertListOfOperationsInTreeView(form);
                form.TreeOfOperations.Nodes.Clear();
                Tables.getParametersOfSurfacesAfterVariousOperations().insertListOfOperationsInTreeView(form);

                form.Surfaces.Visible = false;
                form.NameSurface.Visible = false;
                form.SurfacesTreeView.Visible = false;
                form.addSurfaceButton.Visible = false;
                form.delSurfaceButton.Visible = false;

                form.TreeOfOperations.Size = new Size(400, 287);
                form.TreeOfOperations.Location = new Point(16, 270);

                form.labelOperationsOrTechProcess.Size = new Size(91, 13);
                form.labelOperationsOrTechProcess.Location = new Point(169, 250);
                form.labelOperationsOrTechProcess.Text = "Выбор операций";


                form.SelectTechnologicalProcess.Visible = true;
                form.CalculationOfSchema.Visible = false;
            }
            else
            {
                int indexSelectSurface = StorageOfSelectedOperation.getIndexSelectedSurface();

                Part.insertListOfOperationsInTreeView(form, indexSelectSurface);

                int countOperations = form.TreeOfSelectedOperations.Nodes.Count;
                form.TreeOfSelectedOperations.SelectedNode = form.TreeOfSelectedOperations.Nodes[countOperations - 1];
            }
        }

        public static void storageParametersOfSurface(MainForm form, int selectedIndex)
        {
            int lastSelectedIndex = StorageOfSelectedOperation.getIndexSelectedSurface();

            Part.getSurfaceOnIndex(lastSelectedIndex).setParametersOfSurface(extractionOfParametersOfPartFromTextBoxes(form));
            //Part.getSurfaceOnIndex(selectedIndex).getParametersOfSurface().insertParametersOfPartInTextboxes(form);
        }

        public static ParametersOfSurface extractionOfParametersOfPartFromTextBoxes(MainForm form)
        {
            double diameterOfPart = StringConvertToDoubleOrZero(form.DiameterOfPart.Text);

            TypeOfPart typeOfPart = createType(form.TypeOfPart);
            TypeOfPart typeOfAllowance = createType(form.TypeOfAllowance);
            TypeOfPart typeOfProcessedSurface = createType(form.TypeOfProcessedSurface);

            double surfaceRoughness = StringConvertToDoubleOrZero(form.SurfaceRoughness.Text);
            double allowance = StringConvertToDoubleOrZero(form.Allowance.Text);
            double holeDepth = StringConvertToDoubleOrZero(form.HoleDepth.Text);


            ParametersOfSurface parameters = new ParametersOfSurface(diameterOfPart, typeOfPart, typeOfAllowance, typeOfProcessedSurface, surfaceRoughness, allowance, holeDepth);
            return parameters;
        }

        private static double StringConvertToDoubleOrZero(string str)
        {
            double strToDouble;

            try
            {
                strToDouble = Convert.ToDouble(str);
            }
            catch
            {
                strToDouble = 0;
            }

            return strToDouble;
        }

        private static TypeOfPart createType(ComboBox comboBox)
        {
            string name = comboBox.Text;
            int index = comboBox.SelectedIndex;

            TypeOfPart typeOfPart = new TypeOfPart(name, index);

            return typeOfPart;
        }
    }
}
