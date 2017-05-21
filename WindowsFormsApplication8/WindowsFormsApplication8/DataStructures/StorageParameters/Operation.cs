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
    }
}
