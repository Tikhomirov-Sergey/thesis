using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class ParametersOfWorkpieces
    {
        public DataStructures.PaarametersOfWorkpieces.Workpieces[] workpieces { get; set; }

        public ParametersWorkpiece getParametersWorkprieceOnIndex(int indexWorkpriece)
        {
                return workpieces[indexWorkpriece].getParametersWorkpiece();
        }

        public List<string> getListWorkprieces()
        {
                int length = workpieces.Length;

                List<string> listOfWorkpieces = new List<string>();

                foreach (DataStructures.PaarametersOfWorkpieces.Workpieces workpiece in workpieces)
                {
                    listOfWorkpieces.Add(workpiece.getNameOfWorkpieces());
                }

                return listOfWorkpieces;
        }

        public void insertListOfOperationsInTreeView(FormOfSelectWorkpiece form)
        {
            List<string> workprieces = this.getListWorkprieces();

            foreach (string workpriece in workprieces)
            {
                form.TreeOfWorkpiece.Nodes.Add(workpriece);
            }
        }
    }
}
