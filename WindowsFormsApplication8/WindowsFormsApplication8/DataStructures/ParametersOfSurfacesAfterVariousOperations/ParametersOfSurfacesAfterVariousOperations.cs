using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public Operation getTypeOfMachiningOnIndex(int idOperation)
        {
            try
            {
                string typeOfMachining = operations[idOperation].getTypeOfMachining();

                Operation operation = new Operation(typeOfMachining, idOperation);

                return operation;
            }
            catch
            {
                MessageBox.Show("Операции с введенным индексом не существует", "Ошибка");
                return null;
            }
        }

        public List<ParametersOperation> getListOperationOnSurfaceRoughness(int idOperation, double surfaceRoughness, string nameOperation, string typeOfInstrument)
        {
            try
            {
                List<ParametersOperation>  operations = this.operations[idOperation].getListOperationOnSurfaceRoughness(surfaceRoughness, nameOperation, typeOfInstrument);

                return operations;
            }
            catch { return null; }
        }
    }
}
