using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    public class Operation
    {
        private string nameOperation;
        private int idOperation;
        private string typeOfInstrument;

        public Operation(string nameOperation, int idOperation)
        {
            this.nameOperation = nameOperation;
            this.idOperation = idOperation;
        }

        public string getNameOperation()
        {
            return nameOperation;
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
