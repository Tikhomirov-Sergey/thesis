using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    class Operations
    {
        private string nameSurface = "";
        private ParametersOperation[] operations = new ParametersOperation[0];

        public void setNameSurface(string nameSurface)
        {
            this.nameSurface = nameSurface;
        }

        public string getNameSurface()
        {
            return this.nameSurface;
        }
        
        public void setOpetation(ParametersOperation operation)
        {
            int length = this.operations.Length;
            Array.Resize(ref this.operations, length+1);
            this.operations[length] = operation;
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

            for(int i = 0; i < length; i++)
            {
                list[i] = this.operations[i].getNameOperation();
            }

            return list;
        }
    }
}
