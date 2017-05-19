using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class ParametersOfSurfacesAfterVariousOperations
    {
        public DataStructures.ParametersOfSurfacesAfterVariousOperations.Operations[] operations { get; set; }

        public List<string> getListOperations()
        {
            int length = operations.Length;

            List<string> listOfOperation = new List<string>();

            foreach (DataStructures.ParametersOfSurfacesAfterVariousOperations.Operations operation in operations)
            {
                listOfOperation.Add(operation.getTypeOfMachining());
            }

            return listOfOperation;
        }

        public void insertListOfOperationsInTreeView(MainForm form)
        {
            List<string> operations = this.getListOperations();

            foreach (string operation in operations)
            {
                form.TreeOfOperations.Nodes.Add(operation);
            }
        }
    }
}
