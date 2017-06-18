using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class DependenceOperation
    {
        private int idOnTechnologicalProcess;

        private int numberOperation;
        private string typeOfInstrument;

        private Operation operation;

        public DependenceOperation(int idOnTechnologicalProcess, int numberOperation, string typeOfInstrument)
        {
            this.idOnTechnologicalProcess = idOnTechnologicalProcess;

            this.numberOperation = numberOperation;
            this.typeOfInstrument = typeOfInstrument;
        }

        public int getIdOnTechnologicalProcess()
        {
            return idOnTechnologicalProcess;
        }

        public int getNumberOperation()
        {
            return numberOperation;
        }

        public string getTypeOfInstrument()
        {
            return typeOfInstrument;
        }

        public void setOperationInTechnologicalProcess(Operation operation)
        {
            this.operation = new Operation(operation);
            this.operation.setTypeOfInstrument(typeOfInstrument);
        }

        public Operation getOperation()
        {
            try
            {
                return this.operation;
            }
            catch { return null; }
        }
    }
}
