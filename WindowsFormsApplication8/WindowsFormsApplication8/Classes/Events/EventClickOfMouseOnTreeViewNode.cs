using System;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOfMouseOnTreeViewNode
    {
        public static void clickOnTreeOperations(TreeNodeMouseClickEventArgs e, MainForm form)
        {
            int level;
            level = e.Node.Level;
            
            if(level == 1)
            {
                e.Node.Toggle();
            }
            if(level == 2)
            {
                ParametersOperation parameters = extractionOfParametersOfOperations(e);
                StorageOfSelectedOperation.setParameters(parameters);
                StorageOfSelectedOperation.insertParametersOfOperationsInTextboxes(form);
            }
         }

        public static void clickOnTreeWorkpiece(TreeNodeMouseClickEventArgs e, FormOfSelectWorkpiece form)
        {
            int level;
            level = e.Node.Level;

            if (level == 1)
            {
                ParametersWorkpiece parameters = extractionOfParametersOfWorkpiece(e);

                Part.setWorkpiece(parameters);
                parameters.insertParametersOfWorkpieceInTextboxes(form);
            }
        }
        private static ParametersWorkpiece extractionOfParametersOfWorkpiece(TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;

            string nameOfWorkpiece = node.Text;
            int kvalitet = Convert.ToInt32(node.FirstNode.FirstNode.Text);
            double thicknessOfDefectiveCoating = Convert.ToDouble(node.FirstNode.NextNode.NextNode.FirstNode.Text);
            int idWorkpiece = Convert.ToInt32(node.FirstNode.NextNode.NextNode.NextNode.FirstNode.Text);

            string stringRz = node.FirstNode.NextNode.FirstNode.Text;
            string[] splitStringRz = parseStringRz(stringRz);
            double surfaceRoughnessRz = Convert.ToDouble(splitStringRz[0]);

            string stringRecommendedIntervalRz = splitStringRz[1];
            string[] splitStringRecommendedIntervalRz = parseStringRecommendedIntervalRz(stringRecommendedIntervalRz);
            Interval recommendedIntervalRz = createIntervalRz(splitStringRecommendedIntervalRz);

            ParametersWorkpiece parameters = new ParametersWorkpiece(nameOfWorkpiece, idWorkpiece, surfaceRoughnessRz, recommendedIntervalRz, kvalitet, thicknessOfDefectiveCoating);
            return parameters;
        }

        private static ParametersOperation extractionOfParametersOfOperations(TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;

            string typeOfMachining = node.Parent.Text;
            string precisionOfMachining = node.Text;
            string kvalitet = node.FirstNode.FirstNode.Text;
            string thicknessOfDefectiveCoating = node.FirstNode.NextNode.NextNode.FirstNode.Text;
            string coefficientOfRefinement = node.FirstNode.NextNode.NextNode.NextNode.FirstNode.Text;
            string idOperation = node.FirstNode.NextNode.NextNode.NextNode.NextNode.FirstNode.Text;

            string stringRz = node.FirstNode.NextNode.FirstNode.Text;
            string[] splitStringRz = parseStringRz(stringRz);
            string surfaceRoughnessRz = splitStringRz[0];

            string stringRecommendedIntervalRz = splitStringRz[1];
            string[] splitStringRecommendedIntervalRz = parseStringRecommendedIntervalRz(stringRecommendedIntervalRz);
            Interval recommendedIntervalRz = createIntervalRz(splitStringRecommendedIntervalRz);

            ParametersOperation parameters = new ParametersOperation(typeOfMachining, precisionOfMachining, surfaceRoughnessRz, recommendedIntervalRz, idOperation, kvalitet, thicknessOfDefectiveCoating, coefficientOfRefinement);
            return parameters;
        }

        private static string[] parseString(string str, char symbol)
        {
            string[] splitStr = str.Split(new Char[] { symbol });
            return splitStr;
        }

        private static string[] parseStringRz(string str)
        {
            return parseString(str, '_');
        }

        private static string[] parseStringRecommendedIntervalRz(string str)
        {
            return parseString(str, '-');
        }

        private static Interval createIntervalRz(string[] splitStringRz)
        {
            double min = Convert.ToDouble(splitStringRz[0]);
            double max = Convert.ToDouble(splitStringRz[1]);

            Interval recommendedIntervalRz = new Interval(min, max);
            return recommendedIntervalRz;
        }
        
    }
}
