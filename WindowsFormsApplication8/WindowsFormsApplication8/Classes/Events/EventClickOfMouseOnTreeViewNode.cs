using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    class EventClickOfMouseOnTreeViewNode
    {
        public static void clickOnTreeOperations(TreeNodeMouseClickEventArgs e, Form1 form)
        {
            int level;
            level = e.Node.Level;
            
            if(level == 1)
            {
                e.Node.Toggle();
            }
            if(level == 2)
            {
                ParametersOperationFromTreeview parameters = extractionOfParametersOfOperations(e);
                StorageOfSelectedOperation.setParameters(parameters);
                StorageOfSelectedOperation.insertParametersOfOperationsInTextboxes(form);
            }
         }

        public static void clickOnTreeWorkpiece(TreeNodeMouseClickEventArgs e, Form2 form)
        {
            int level;
            level = e.Node.Level;

            if (level == 1)
            {
                ParametersWorkpieceFromTreeview parameters = extractionOfParametersOfWorkpiece(e);
                StorageOfSelectedWorkpiece.setParameters(parameters);
                StorageOfSelectedWorkpiece.insertParametersOfOperationsInTextboxes(form);
            }
        }
        private static ParametersWorkpieceFromTreeview extractionOfParametersOfWorkpiece(TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;

            string nameOfWorkpiece = node.Text;
            string kvalitet = node.FirstNode.FirstNode.Text;
            string thicknessOfDefectiveCoating = node.FirstNode.NextNode.NextNode.FirstNode.Text;
            string idWorkpiece = node.FirstNode.NextNode.NextNode.NextNode.FirstNode.Text;

            string stringRz = node.FirstNode.NextNode.FirstNode.Text;
            string[] splitStringRz = parseStringRz(stringRz);
            string surfaceRoughnessRz = splitStringRz[0];

            string stringRecommendedIntervalRz = splitStringRz[1];
            string[] splitStringRecommendedIntervalRz = parseStringRecommendedIntervalRz(stringRecommendedIntervalRz);
            Interval recommendedIntervalRz = createIntervalRz(splitStringRecommendedIntervalRz);

            ParametersWorkpieceFromTreeview parameters = new ParametersWorkpieceFromTreeview(nameOfWorkpiece, idWorkpiece, surfaceRoughnessRz, recommendedIntervalRz, kvalitet, thicknessOfDefectiveCoating);
            return parameters;
        }

        private static ParametersOperationFromTreeview extractionOfParametersOfOperations(TreeNodeMouseClickEventArgs e)
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

            ParametersOperationFromTreeview parameters = new ParametersOperationFromTreeview(typeOfMachining, precisionOfMachining, surfaceRoughnessRz, recommendedIntervalRz, idOperation, kvalitet, thicknessOfDefectiveCoating, coefficientOfRefinement);
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
