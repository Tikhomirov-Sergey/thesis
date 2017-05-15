using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class ParametersOfWorkpieces
    {
        public DataStructures.PaarametersOfWorkpieces.Workpieces[] workpieces { get; set; }

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
    }
}
