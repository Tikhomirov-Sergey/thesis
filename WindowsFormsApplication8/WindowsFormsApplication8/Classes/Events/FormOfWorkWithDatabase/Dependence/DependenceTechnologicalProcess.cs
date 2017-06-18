using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class DependenceOperationInTechnologicalProcess
    {

        private int idInDb;
        private Operation operation;

        public DependenceOperationInTechnologicalProcess(int idInDb, string typeOfMachining, int idOperation, int idOnTechnologicalProcess)
        {
            this.idInDb = idInDb;
            this.operation = new Operation(typeOfMachining, idOperation, idOnTechnologicalProcess);
        }

        public int getIdInDb()
        {
            return idInDb;
        }

        public Operation getOperation()
        {
            return operation;
        }
    }
}
