using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class Operation
    {
        private string typeOfMachining;
        private int idOperation;
        private string typeOfInstrument;

        private int idOnTechnologicalProcess;

        public Operation(string typeOfMachining, int idOperation, int idOnTechnologicalProcess)
        {
            this.typeOfMachining = typeOfMachining;
            this.idOperation = idOperation;
            this.idOnTechnologicalProcess = idOnTechnologicalProcess;
        }

        public Operation(string typeOfMachining, int idOperation)
        {
            this.typeOfMachining = typeOfMachining;
            this.idOperation = idOperation;
        }

        public Operation(Operation operation)
        {
            this.typeOfMachining = operation.getTypeOfMachining();
            this.idOperation = operation.getIdOperation();
            this.typeOfInstrument = operation.getTypeOfInstrument();
            this.idOnTechnologicalProcess = operation.getIdOnTechnologicalProcess();
        }

        public void setTypeOfMachining(string typeOfMachining)
        {
            this.typeOfMachining = typeOfMachining;
        }

        public string getTypeOfMachining()
        {
            return typeOfMachining;
        }

        public int getIdOperation()
        {
            return idOperation;
        }

        public void setTypeOfInstrument(string typeOfInstrument)
        {
            this.typeOfInstrument = typeOfInstrument;
        }

        public string getTypeOfInstrument()
        {
            return typeOfInstrument;
        }

        public void setIdOnTechnologicalProcess(int idOnTechnologicalProcess)
        {
            this.idOnTechnologicalProcess = idOnTechnologicalProcess;
        }

        public int getIdOnTechnologicalProcess()
        {
            return idOnTechnologicalProcess;
        }
    }
}
