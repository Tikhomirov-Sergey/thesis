using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class TechnologicalProcess
    {
        private ParametersOperation[] operations = new ParametersOperation[0];


        public void setOpetation(ParametersOperation operation, int indexOfOperation = -1)
        {
            if (indexOfOperation.Equals(-1))
            {
                indexOfOperation = getNumberOfOperations();
            }

            try
            {
                List<ParametersOperation> parametersOperationToList = this.operations.ToList<ParametersOperation>();
                parametersOperationToList.Insert(indexOfOperation, operation);
                this.operations = parametersOperationToList.ToArray<ParametersOperation>();
            }
            catch { }
        }

        public ParametersOperation[] getOperations()
        {
            return this.operations;
        }

        public ParametersOperation getOperationOnIndex(int indexOperation)
        {
            try
            {
                return operations[indexOperation];
            }
            catch { return null; }
        }

        public string[] getListOperations()
        {
            int length = this.operations.Length;
            string[] list = new string[length];

            for (int i = 0; i < length; i++)
            {
                list[i] = this.operations[i].getNameOperation();
            }

            return list;
        }

        public int getNumberOfOperations()
        {
            return this.operations.Length;
        }

        public void insertListOfOperationsInTreeView(MainForm form)
        {
            string[] listOfSurface = this.getListOperations();
            int numberOfOperations = this.getNumberOfOperations();

            for (int i = 1; i <= numberOfOperations; i++)
            {
                if (form.TreeOfSelectedOperations.Nodes.Count <= i)
                {
                    form.TreeOfSelectedOperations.Nodes.Add(listOfSurface[i - 1]);
                }
                else
                {
                    form.TreeOfSelectedOperations.Nodes[i].Text = listOfSurface[i - 1];
                }
            }

            for (int i = numberOfOperations + 1; i < form.TreeOfSelectedOperations.Nodes.Count; i++)
            {
                form.TreeOfSelectedOperations.Nodes.RemoveAt(i);
            }

            StorageOfSelectedOperation.setIndexSelectedOperation(numberOfOperations);
            form.TreeOfSelectedOperations.SelectedNode = form.TreeOfSelectedOperations.Nodes[numberOfOperations];
        }

        public void deleteOperation(int indexOfOperation)
        {
            try
            {
                List<ParametersOperation> parametersOperationToList = this.operations.ToList<ParametersOperation>();
                parametersOperationToList.RemoveAt(indexOfOperation);
                this.operations = parametersOperationToList.ToArray<ParametersOperation>();
            }
            catch { }
        }


    }
}
