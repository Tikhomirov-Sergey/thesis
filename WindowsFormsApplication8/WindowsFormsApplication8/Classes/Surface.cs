using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.Classes
{
    class Surface
    {
        private ParametersOperationFromTreeview[] operations = new ParametersOperationFromTreeview[0];

        public void setOperation(ParametersOperationFromTreeview operation)
        {
            int lenght = this.operations.Length; 
            Array.Resize(ref this.operations, lenght++);
            operations[lenght] = operation;
        }

        public ParametersOperationFromTreeview[] getOperations()
        {
            return this.operations;
        }

        
    }
}
